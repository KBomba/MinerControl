namespace MinerControl.PriceEntries
{
    public class WePayBtcPriceEntry : PriceEntryBase
    {
        public override decimal Fees
        {
            //get { return Earn * 0.02m; }
            get { return 0m; }
            set { base.Fees = value; }
        }
    }
}