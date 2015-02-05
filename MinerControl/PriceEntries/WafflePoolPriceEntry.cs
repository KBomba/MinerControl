namespace MinerControl.PriceEntries
{
    public class WafflePoolPriceEntry : PriceEntryBase
    {
        public override decimal Fees
        {
            get { return Earn*0.02m; }
            set { base.Fees = value; }
        }
    }
}