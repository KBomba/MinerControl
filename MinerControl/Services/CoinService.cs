using System;
using System.Collections.Generic;
using MinerControl.PriceEntries;
using MinerControl.Utility;

namespace MinerControl.Services
{
    public class CoinService: ServiceBase<CoinPriceEntry>
    {
        private const string Url = "http://www.whattomine.com/coins.json";
        private decimal _minVolume;

        public CoinService(string pool)
        {
            ServiceName = pool;
            DonationAccount = "VrovuTn6CTvRQfXCY6Z4uifYiDturyMuhv";
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            decimal fee = 0;
            if (data.ContainsKey("fee"))
                fee = data["fee"].ExtractDecimal();
            if (data.ContainsKey("minvolume"))
                _minVolume = data["minvolume"].ExtractDecimal();

            object[] items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                CoinPriceEntry entry = CreateEntry(item);

                entry.FeePercent = fee;

                Add(entry);
            }
        }

        public override void CheckPrices()
        {
            ClearStalePrices();

            WebUtil.DownloadJson(Url, ProcessPrices);
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

                    CoinPriceEntry entry = GetEntry(algo);
                    if (entry == null) continue;

                    decimal price;
                    switch (0)
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
                }

                MiningEngine.PricesUpdated = true;
                MiningEngine.HasPrices = true;

                LastUpdated = DateTime.Now;

                UpdateHistory();
            }
        }
    }
}