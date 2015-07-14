using System;
using System.Collections.Generic;
using MinerControl.PriceEntries;
using MinerControl.Utility;

namespace MinerControl.Services
{
    public class HashpowerService : ServiceBase<HashpowerPriceEntry>
    {
        // http://hashpower.co/api/status
        // {
        //   "scrypt": {"name": "scrypt", "port": 3433, "coins": 21, "fees": 0.5, "hashrate": 1585708947, "estimate_current": 0.00017441, "estimate_last24h": 0.00018214, "actual_last24h": 0.00019935}, 
        //   "scryptn": {"name": "scryptn", "port": 4333, "coins": 3, "fees": 3.2, "hashrate": 88775354, "estimate_current": 0.00042183, "estimate_last24h": 0.00045701, "actual_last24h": 0.00039583}, 
        //   "neoscrypt": {"name": "neoscrypt", "port": 4233, "coins": 4, "fees": 2.8, "hashrate": 359254951, "estimate_current": 0.00217158, "estimate_last24h": 0.00352892, "actual_last24h": 0.00320471}, 
        //   "quark": {"name": "quark", "port": 4033, "coins": 3, "fees": 0.5, "hashrate": 85473584, "estimate_current": 0.00000078, "estimate_last24h": 0.00000087, "actual_last24h": 0.00020362}, 
        //   "lyra2": {"name": "lyra2", "port": 4433, "coins": 1, "fees": 0.6, "hashrate": 16864909, "estimate_current": 0.00062095, "estimate_last24h": 0.00063257, "actual_last24h": 0.00090811}, 
        //   "x11": {"name": "x11", "port": 3533, "coins": 10, "fees": 1.3, "hashrate": 7793602368, "estimate_current": 0.00019716, "estimate_last24h": 0.00015537, "actual_last24h": 0.00016760}, 
        //   "x13": {"name": "x13", "port": 3633, "coins": 2, "fees": 3.7, "hashrate": 2500273917, "estimate_current": 0.00019537, "estimate_last24h": 0.00016803, "actual_last24h": 0.00017710}, 
        //   "x14": {"name": "x14", "port": 3933, "coins": 1, "fees": 3.5, "hashrate": 54660672, "estimate_current": 0.00032863, "estimate_last24h": 0.00025539, "actual_last24h": 0.00025089}, 
        //   "x15": {"name": "x15", "port": 3733, "coins": 3, "fees": 5.4, "hashrate": 5870269795, "estimate_current": 0.00126368, "estimate_last24h": 0.00025544, "actual_last24h": 0.00082305}
        // }

        private int _balanceMode;
        private int _priceMode;

        public HashpowerService()
        {
            ServiceName = "Hashpower";
            DonationAccount = "1PMj3nrVq5CH4TXdJSnHHLPdvcXinjG72y";
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            if (data.ContainsKey("pricemode"))
                _priceMode = int.Parse(data["pricemode"].ToString());
            if (data.ContainsKey("balancemode"))
                _balanceMode = int.Parse(data["balancemode"].ToString());

            object[] items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                HashpowerPriceEntry entry = CreateEntry(item);

                Add(entry);
            }
        }

        public override void CheckPrices()
        {
            ClearStalePrices();
            WebUtil.DownloadJson("http://hashpower.co/api/status", ProcessPrices);
            WebUtil.DownloadJson(string.Format("http://hashpower.co/api/wallet?address={0}", _account), ProcessBalances);
        }

        private void ProcessPrices(object jsonData)
        {
            Dictionary<string, object> data = jsonData as Dictionary<string, object>;

            lock (MiningEngine)
            {
                foreach (string key in data.Keys)
                {
                    object rawitem = data[key];
                    Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                    string algo = key.ToLower();

                    HashpowerPriceEntry entry = GetEntry(algo);
                    if (entry == null) continue;

                    decimal price;
                    switch (_priceMode)
                    {
                        case 1:
                            price = item["estimate_last24h"].ExtractDecimal();
                            break;
                        case 2:
                            price = item["actual_last24h"].ExtractDecimal();
                            break;
                        default:
                            price = item["estimate_current"].ExtractDecimal();
                            break;
                    }
                    entry.Price = algo != "sha256" ? price*1000 : price;

                    decimal feePercent = item["fees"].ExtractDecimal();
                    entry.FeePercent = _account.Trim()[0] == '1' ? feePercent + 1.5M : feePercent;
                    // If conversion to BTC is needed (as most do), fee is +1.5%
                }

                MiningEngine.PricesUpdated = true;
                MiningEngine.HasPrices = true;

                LastUpdated = DateTime.Now;

                UpdateHistory();
            }
        }

        private void ProcessBalances(object jsonData)
        {
            Dictionary<string, object> data = jsonData as Dictionary<string, object>;

            lock (MiningEngine)
            {
                switch (_balanceMode)
                {
                    case 1:
                        Balance = data["balance"].ExtractDecimal();
                        break;
                    case 2:
                        Balance = data["unsold"].ExtractDecimal();
                        break;
                    case 3:
                        Balance = data["paid"].ExtractDecimal();
                        break;
                    case 4:
                        Balance = data["total"].ExtractDecimal();
                        break;
                    default:
                        Balance = data["unpaid"].ExtractDecimal();
                        break;
                }


                foreach (HashpowerPriceEntry entry in PriceEntries)
                    entry.AcceptSpeed = 0;

                if (!data.ContainsKey("miners")) return;
                Dictionary<string, object> miners = data["miners"] as Dictionary<string, object>;
                foreach (string key in miners.Keys)
                {
                    HashpowerPriceEntry entry = GetEntry(key.ToLower());
                    if (entry == null) continue;
                    Dictionary<string, object> item = miners[key] as Dictionary<string, object>;
                    entry.AcceptSpeed = item["hashrate"].ExtractDecimal()/1000000;
                }

                MiningEngine.PricesUpdated = true;
            }
        }
    }
}