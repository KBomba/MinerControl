using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MinerControl.PriceEntries;

namespace MinerControl
{
    public class ServiceHistory
    {
        public ServiceEnum Service { get; set; }

        private readonly TimeSpan _statWindow;
        private readonly double _outlierPercentage;

        public Dictionary<PriceEntryBase, List<PriceStat>> PriceList { get; set; } // PriceEntry:list of stats
        public class PriceStat
        {
            public DateTime Time { get; set; }
            public decimal CurrentPrice { get; set; }

            public decimal WindowedAveragePrice { get; set; } // Uses statwindow time to get an average
            public decimal TotalAveragePrice { get; set; }
            public bool Outlier { get; set; }
        }

        public ServiceHistory(ServiceEnum service, TimeSpan window, double outlierPercentage)
        {
            Service = service;
            _statWindow = window;
            _outlierPercentage = outlierPercentage;
            PriceList = new Dictionary<PriceEntryBase, List<PriceStat>>();
        }

        public void UpdatePrice(PriceEntryBase priceEntryBase)
        {
            DateTime now = DateTime.Now;
            decimal price = priceEntryBase.NetEarn;
            
            decimal totalPrice = price;
            int totalCount = PriceList.Count;
            
            List<decimal> window = new List<decimal> {price};
            decimal windowedPrice = price;
            int windowedCount = 0;
            bool outlier = false;

            if (!PriceList.ContainsKey(priceEntryBase)) 
                PriceList.Add(priceEntryBase, new List<PriceStat>());

            foreach (PriceStat stat in PriceList[priceEntryBase])
            {
                decimal historicPrice = stat.CurrentPrice;
                totalPrice += historicPrice;

                if (stat.Time == now) return;
                if (stat.Time >= now - _statWindow)
                {
                    window.Add(historicPrice);
                    windowedPrice += historicPrice;
                    windowedCount++;
                }
            }

            if (windowedCount >= 10)
            {
                window.Sort();
                int outlierIndex = (int) Math.Truncate(window.Count*_outlierPercentage);
                decimal[] outliers = {window[outlierIndex], window[window.Count - outlierIndex]};
                if (/*price <= outliers.Min() ||*/ price > outliers.Max())
                {
                    outlier = true;
                }
            }

            PriceStat priceStat = new PriceStat
            {
                Time = now,
                CurrentPrice = price,
                TotalAveragePrice = totalPrice/(totalCount+1),
                WindowedAveragePrice = windowedPrice/(windowedCount+1),
                Outlier = outlier
            };

            priceEntryBase.Outlier = outlier;

            PriceList[priceEntryBase].Add(priceStat);
        }
    }
}
