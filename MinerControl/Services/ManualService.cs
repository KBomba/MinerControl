using System;
using System.Collections.Generic;
using MinerControl.PriceEntries;

namespace MinerControl.Services
{
    public class ManualService : ServiceBase<ManualPriceEntry>
    {
        public ManualService()
        {
            ServiceName = "Manual";
        }

        public ManualService(string name)
        {
            ServiceName = name;
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            object[] items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                Dictionary<string, object> item = rawitem as Dictionary<string, object>;
                ManualPriceEntry entry = CreateEntry(item);

                if (item.ContainsKey("price"))
                    entry.Price = item["price"].ExtractDecimal();
                if (item.ContainsKey("fee"))
                    entry.FeePercent = item["fee"].ExtractDecimal();

                Add(entry);
            }
        }

        public override void CheckPrices()
        {
            lock (MiningEngine)
            {
                MiningEngine.PricesUpdated = true;
                MiningEngine.HasPrices = true;

                LastUpdated = DateTime.Now;

                UpdateHistory();
            }
        }
    }
}