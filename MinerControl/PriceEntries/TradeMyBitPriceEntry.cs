namespace MinerControl.PriceEntries
{
    public class TradeMyBitPriceEntry : PriceEntryBase
    {
        public override decimal Fees
        {
            get { return Earn*0.025m; }
            set { base.Fees = value; }
        }
    }
}