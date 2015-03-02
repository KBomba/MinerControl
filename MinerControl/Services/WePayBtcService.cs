using System;
using System.Collections.Generic;
using MinerControl.PriceEntries;
using MinerControl.Utility;

namespace MinerControl.Services
{
    public class WePayBtcService : ServiceBase<WePayBtcPriceEntry>
    {
        // http://wepaybtc.com/payouts.json

        //{
        //    "reference": 0.001,
        //    "x11": 0.0002066,
        //    "x13": 0.0002985,
        //    "x15": 0.0003717,
        //    "nist5": 0.00006863
        //}

        public WePayBtcService()
        {
            ServiceEnum = ServiceEnum.WePayBTC;
            DonationAccount = "1PMj3nrVq5CH4TXdJSnHHLPdvcXinjG72y";
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            object[] items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                WePayBtcPriceEntry entry = CreateEntry(item);

                Add(entry);
            }
        }

        public override void CheckPrices()
        {
            ClearStalePrices();
            WebUtil.DownloadJson("http://wepaybtc.com/payouts.json", ProcessPrices);
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

                    WePayBtcPriceEntry entry = GetEntry(algo);
                    if (entry == null) continue;

                    entry.Price = data[key].ExtractDecimal()*1000;
                }

                MiningEngine.PricesUpdated = true;
                MiningEngine.HasPrices = true;

                LastUpdated = DateTime.Now;

                UpdateHistory();
            }
        }
    }
}