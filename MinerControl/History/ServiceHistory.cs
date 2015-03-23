using System;
using System.Collections.Generic;
using System.Linq;
using MinerControl.PriceEntries;

namespace MinerControl.History
{
    public class ServiceHistory
    {
        public ServiceEnum Service { get; set; }

        private readonly TimeSpan _statWindow;
        private readonly double _percentile;
        private readonly decimal _iqrMultiplier;

        public Dictionary<PriceEntryBase, List<PriceStat>> PriceList { get; set; } // PriceEntry:list of stats
        public class PriceStat
        {
            public DateTime Time { get; set; }
            public decimal CurrentPrice { get; set; }

            public decimal WindowedAveragePrice { get; set; } // Uses statwindow time to get an average
            public decimal TotalAveragePrice { get; set; }
            public bool Outlier { get; set; }
        }

        public ServiceHistory(ServiceEnum service, TimeSpan window, double percentile, decimal iqrMultiplier)
        {
            Service = service;
            _statWindow = window;
            _percentile = percentile;
            _iqrMultiplier = iqrMultiplier;
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

            decimal totalAveragePrice = totalPrice/(totalCount+1);
            decimal windowedAveragePrice = windowedPrice/(windowedCount+1);

            if (windowedCount >= 10) // Makes sure at least ten entries are in there
            {
                window.Sort();
                if (_iqrMultiplier > 0)
                {
                    int iqrIndex = (int) Math.Truncate(window.Count*0.75);
                    decimal iqr = window[iqrIndex] - window[window.Count - iqrIndex];
                    outlier = price > windowedAveragePrice + (_iqrMultiplier*iqr);
                }
                else
                {
                    // If the IQR multiplier is negative or zero, 
                    // it'll try to use percentiles for outlierdetection
                    // Not advised! Will kill off trending profits, iqr-multiplying is preferable 
                    int outlierIndex = (int) Math.Truncate(window.Count*_percentile);
                    decimal[] outliers = {window[outlierIndex], window[window.Count - outlierIndex]};
                    outlier = price > outliers.Max();
                }
            }


            PriceStat priceStat = new PriceStat
            {
                Time = now,
                CurrentPrice = price,
                TotalAveragePrice = totalAveragePrice,
                WindowedAveragePrice = windowedAveragePrice,
                Outlier = outlier
            };

            priceEntryBase.Outlier = outlier;
            priceEntryBase.NetAverage = windowedAveragePrice;

            PriceList[priceEntryBase].Add(priceStat);
        }
    }
}
