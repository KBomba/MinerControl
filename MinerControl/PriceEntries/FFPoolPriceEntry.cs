namespace MinerControl.PriceEntries
{
    public class FFPoolPriceEntry : PriceEntryBase
    {
        public decimal FeePercent { get; set; }

        public override decimal Fees
        {
            get { return Earn*(FeePercent/100); }
            set { base.Fees = value; }
        }
    }
}