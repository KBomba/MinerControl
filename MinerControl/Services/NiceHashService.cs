using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using MinerControl.PriceEntries;
using MinerControl.Utility;

namespace MinerControl.Services
{
    public class NiceHashService : ServiceBase<NiceHashPriceEntry>
    {
        private readonly IDictionary<string, int> _algoTranslation = new Dictionary<string, int>
        {
            {"x11", 3},
            {"x13", 4},
            {"scrypt", 0},
            {"scryptn", 2},
            {"keccak", 5},
            {"sha256", 1},
            {"x15", 6},
            {"nist5", 7},
            {"neoscrypt", 8},
            {"lyra2", 9},
            {"whirlpoolx", 10},
            {"qubit", 11},
            {"quark", 12}
        };

        private Dictionary<string, double> _pingTimes;
        private bool _useWestHash; // When .usa, .hk, or .jp is used, balance calls should be done to westhash 
        public bool DetectStratum; 

        public NiceHashService()
        {
            ServiceName = "NiceHash";
            DonationAccount = "1PMj3nrVq5CH4TXdJSnHHLPdvcXinjG72y";
            DonationWorker = "1";
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            if ((data.ContainsKey("detectstratum") && (bool) data["detectstratum"]))
            {
                DetectStratum = true;
                InitPingTimes(); // Quick sync test
                CheckPingTimes(); // Thorough async test
            }
            else
            {
                DetectStratum = false;
                if (!_param1.Contains(".eu.") && !_param2.Contains(".eu.") && !_param3.Contains(".eu.")) _useWestHash = true;
            }

            object[] items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                NiceHashPriceEntry entry = CreateEntry(item);
                if (string.IsNullOrWhiteSpace(entry.PriceId))
                    entry.PriceId = GetAgorithmId(entry.AlgoName).ToString();

                Add(entry);
            }
        }

        public override void CheckPrices()
        {
            ClearStalePrices();
            WebUtil.DownloadJson("https://www.nicehash.com/api?method=stats.global.current", ProcessPrices);

            string apiUrl = _useWestHash
                ? "https://www.westhash.com/api?method=stats.provider&addr={0}"
                : "https://www.nicehash.com/api?method=stats.provider&addr={0}";
            WebUtil.DownloadJson(
                string.Format(apiUrl, _account), ProcessBalances);
        }

        private void ProcessPrices(object jsonData)
        {
            Dictionary<string, object> data = jsonData as Dictionary<string, object>;
            Dictionary<string, object> result = data["result"] as Dictionary<string, object>;
            object[] stats = result["stats"] as object[];

            lock (MiningEngine)
            {
                foreach (object stat in stats)
                {
                    Dictionary<string, object> item = stat as Dictionary<string, object>;
                    string algo = item["algo"].ToString();
                    NiceHashPriceEntry entry = GetEntry(algo);
                    if (entry == null) continue;

                    entry.Price = item["price"].ExtractDecimal();
                    switch (entry.AlgoName)
                    {
                        case "sha256":
                            entry.Price = item["price"].ExtractDecimal()/1000; // SHA256 listed in TH/s
                            break;
                        default:
                            entry.Price = item["price"].ExtractDecimal(); // All others in GH/s
                            break;
                    }
                }

                MiningEngine.PricesUpdated = true;
                MiningEngine.HasPrices = true;

                LastUpdated = DateTime.Now;

                UpdateHistory();
            }
        }

        private void ProcessBalances(object jsonData)
        {
            decimal totalBalance = 0m;
            Dictionary<string, object> data = jsonData as Dictionary<string, object>;
            Dictionary<string, object> result = data["result"] as Dictionary<string, object>;
            object[] stats = result["stats"] as object[];
            foreach (object stat in stats)
            {
                Dictionary<string, object> item = stat as Dictionary<string, object>;
                totalBalance += item["balance"].ExtractDecimal();
                string algo = item["algo"].ToString();
                NiceHashPriceEntry entry = GetEntry(algo);
                if (entry == null) continue;

                entry.Balance = item["balance"].ExtractDecimal();
                switch (entry.AlgoName)
                {
                    case "sha256":
                        entry.AcceptSpeed = item["accepted_speed"].ExtractDecimal();
                        entry.RejectSpeed = item["rejected_speed"].ExtractDecimal();
                        break;
                    default:
                        entry.AcceptSpeed = item["accepted_speed"].ExtractDecimal()*1000;
                        entry.RejectSpeed = item["rejected_speed"].ExtractDecimal()*1000;
                        break;
                }
            }

            lock (MiningEngine)
            {
                Balance = totalBalance;
            }
        }

        private int GetAgorithmId(string algorithmName)
        {
            return _algoTranslation[algorithmName];
        }

        private void InitPingTimes()
        {
            const int tries = 3;

            _pingTimes = new Dictionary<string, double>(4)
                {
                    {".eu.nicehash.com", 0},
                    {".usa.nicehash.com", 0},
                    {".hk.nicehash.com", 0},
                    {".jp.nicehash.com", 0}
                };

            Dictionary<string, double> clone = new Dictionary<string, double>(4);

            foreach (string url in _pingTimes.Keys)
            {
                Ping pinger = new Ping();
                double roundTripTime = 0;

                for (int i = 0; i < tries; i++)
                {
                    try
                    {
                        PingReply reply = pinger.Send("speedtest" + url, 500);
                        roundTripTime = CheckRoundTripTime(reply, url, roundTripTime);
                    }
                    catch
                    {
                        roundTripTime += 1000;
                    }
                }

                clone.Add(url, roundTripTime / tries);
            }

            _pingTimes = clone;
            DetermineWestHashUsage();
        }

        public async void CheckPingTimes()
        {
            const int tries = 50;
            Dictionary<string, double> clone = new Dictionary<string, double>(4);
            foreach (string url in _pingTimes.Keys)
            {
                Ping pinger = new Ping();
                double roundTripTime = 0;
                
                for (int i = 0; i < tries; i++)
                {
                    try
                    {
                        PingReply reply = await pinger.SendPingAsync("speedtest" + url, 1000);
                        roundTripTime = CheckRoundTripTime(reply, url, roundTripTime);
                    }
                    catch
                    {
                        roundTripTime += 1000;
                    }
                }

                clone.Add(url, roundTripTime / tries);
            }

            _pingTimes = clone;
            DetermineWestHashUsage();
        }

        private static double CheckRoundTripTime(PingReply reply, string url, double roundTripTime)
        {
            if (reply != null && reply.Status == IPStatus.Success)
            {
                switch (url)
                {
                    case ".hk.nicehash.com":
                        roundTripTime += 150 + reply.RoundtripTime;
                        break;
                    case ".jp.nicehash.com":
                        roundTripTime += 100 + reply.RoundtripTime;
                        break;
                    default:
                        roundTripTime += reply.RoundtripTime;
                        break;
                }
            }
            else
            {
                roundTripTime += 1000;
            }

            return roundTripTime;
        }

        private void DetermineWestHashUsage()
        {
            _useWestHash = _pingTimes.OrderBy(ping => ping.Value).First().Key != ".eu.nicehash.com";
            ServiceName = _useWestHash ? "WestHash" : "NiceHash";
        }

        public string GetBestStratum(string algorithmName)
        {
            string substituteAlgo;
            switch (algorithmName)
            {
                case "lyra2":
                    substituteAlgo = "lyra2re";
                    break;
                case "scryptn":
                    substituteAlgo = "scryptnf";
                    break;
                default:
                    substituteAlgo = algorithmName;
                    break;
            }

            int port = 3333 + _algoTranslation[algorithmName]; // 3333 + priceid = port
            return substituteAlgo + _pingTimes.OrderBy(ping => ping.Value).First().Key
                   + ":" + port;
        }
    }
}