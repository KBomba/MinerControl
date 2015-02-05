using System.Collections.Generic;
using MinerControl.PriceEntries;

namespace MinerControl.Services
{
    public class ManualService : ServiceBase<ManualPriceEntry>
    {
        public ManualService()
        {
            ServiceEnum = ServiceEnum.Manual;
        }

        public override void Initialize(IDictionary<string, object> data)
        {
            ExtractCommon(data);

            var items = data["algos"] as object[];
            foreach (object rawitem in items)
            {
                var item = rawitem as Dictionary<string, object>;
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
        }
    }
}