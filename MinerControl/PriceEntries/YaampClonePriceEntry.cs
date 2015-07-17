﻿namespace MinerControl.PriceEntries
{
    public class YaampClonePriceEntry : PriceEntryBase
    {
        public decimal FeePercent { get; set; }

        public override decimal Fees
        {
            get { return Earn*(FeePercent/100); }
            set { base.Fees = value; }
        }
    }
}