using System;
using System.Drawing;
using MinerControl.Services;
using MinerControl.Utility;

namespace MinerControl.PriceEntries
{
    public abstract class PriceEntryBase : PropertyChangedBase
    {
        private decimal _acceptSpeed;
        private decimal _balance;
        private bool _banned;
        private bool _belowMinPrice;
        private bool _outlier;
        private DateTime _deadTime;
        private decimal _fees;
        private decimal _price;
        private decimal _rejectSpeed;
        private TimeSpan _timeMining;
        private decimal _weight;
        private Color? _color;

        public PriceEntryBase()
        {
            Weight = 1.0m;
            DeadTime = DateTime.MinValue;
        }

        public MiningEngine MiningEngine { get; set; }
        public int Id { get; set; }
        public IService ServiceEntry { get; set; }
        public string PriceId { get; set; }
        public string AlgoName { get; set; }
        public string Name { get; set; }
        public bool UseWindow { get; set; }
        public decimal MinProfit { get; set; }
        
        public decimal Hashrate { get; set; }
        public decimal Power { get; set; }
        public string Priority { get; set; }
        public int Affinity { get; set; }
        public string Folder { get; set; }
        public string Command { get; set; }
        public string Arguments { get; set; }
        public string DonationFolder { get; set; }
        public string DonationCommand { get; set; }
        public string DonationArguments { get; set; }

        public decimal NetAverage { get; set; }

        public decimal Price
        {
            get { return _price; }
            set { SetField(ref _price, value, () => Price, () => Earn, () => Fees, () => NetEarn); }
        }

        public decimal Earn
        {
            get { return Price/1000*Hashrate/1000; }
        }

        public decimal PowerCost
        {
            get { return Power/1000*24*MiningEngine.PowerCost/MiningEngine.Exchange; }
        }

        public virtual decimal Fees
        {
            get { return _fees; }
            set { SetField(ref _fees, value, () => Fees, () => NetEarn); }
        }

        public decimal Weight
        {
            get { return _weight; }
            set { SetField(ref _weight, value, () => Weight, () => NetEarn); }
        }

        public decimal NetEarn
        {
            get { return ((Earn - Fees)*Weight) - PowerCost; }
        }

        public Color? Color
        {
            get
            {
                return _color ?? (_color = (ServiceEntry.ServiceName + AlgoName).GetColorRepresentation());
            }
        }

        public decimal Balance
        {
            get { return _balance; }
            set { SetField(ref _balance, value, () => Balance, () => BalancePrint); }
        }

        public decimal AcceptSpeed
        {
            get { return _acceptSpeed; }
            set { SetField(ref _acceptSpeed, value, () => AcceptSpeed, () => AcceptSpeedPrint); }
        }

        public decimal RejectSpeed
        {
            get { return _rejectSpeed; }
            set { SetField(ref _rejectSpeed, value, () => RejectSpeed, () => RejectSpeedPrint); }
        }

        public TimeSpan TimeMining
        {
            get { return _timeMining; }
            set { SetField(ref _timeMining, value, () => TimeMining, () => TimeMiningPrint); }
        }

        public bool Banned
        {
            get { return _banned; }
            set { SetField(ref _banned, value, () => Banned, () => StatusPrint); }
        }

        public bool BelowMinPrice
        {
            get { return _belowMinPrice; }
            set { SetField(ref _belowMinPrice, value, () => BelowMinPrice, () => StatusPrint); }
        }

        public bool Outlier
        {
            get { return _outlier; }
            set { SetField(ref _outlier, value, () => Outlier, () => StatusPrint); }
        }

        public DateTime DeadTime
        {
            get { return _deadTime; }
            set { SetField(ref _deadTime, value, () => DeadTime, () => StatusPrint); }
        }

        public bool IsDead
        {
            get { return (DeadTime + MiningEngine.DeadTime) > DateTime.Now; }
        }

        public TimeSpan TimeMiningWithCurrent
        {
            get
            {
                return MiningEngine.CurrentRunning.HasValue && MiningEngine.CurrentRunning.Value == Id &&
                       MiningEngine.StartMining.HasValue
                    ? (TimeMining + (DateTime.Now - MiningEngine.StartMining.Value))
                    : TimeMining;
            }
        }

        public string ServicePrint
        {
            get { return ServiceEntry.ServiceName; }
        }

        public string BalancePrint
        {
            get { return Balance == 0.0m ? string.Empty : Balance.ToString("N8"); }
        }

        public string AcceptSpeedPrint
        {
            get { return AcceptSpeed == 0.0m ? string.Empty : AcceptSpeed.ToString("N2"); }
        }

        public string RejectSpeedPrint
        {
            get { return RejectSpeed == 0.0m ? string.Empty : RejectSpeed.ToString("N2"); }
        }

        public string TimeMiningPrint
        {
            get { return TimeMiningWithCurrent.FormatTime(true); }
        }

        public string StatusPrint
        {
            get
            {
                if (MiningEngine.CurrentRunning.HasValue && MiningEngine.CurrentRunning.Value == Id)
                    return "Running";
                if (IsDead)
                    return "Dead";
                if (Banned)
                    return "Banned";
                if (BelowMinPrice)
                    return "Too low";
                if (Outlier)
                    return "Outlier";
                if (MiningEngine.NextRun.HasValue && MiningEngine.NextRun.Value == Id)
                    return "Pending";
                return string.Empty;
            }
        }

        public void UpdateStatus()
        {
            OnPropertyChanged(() => StatusPrint);
            OnPropertyChanged(() => TimeMiningPrint);
            ServiceEntry.UpdateTime();
        }

        public void UpdateExchange()
        {
            OnPropertyChanged(() => PowerCost);
            OnPropertyChanged(() => NetEarn);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((PriceEntryBase) obj);
        }

        protected bool Equals(PriceEntryBase other)
        {
            return Id == other.Id && Equals(ServiceEntry, other.ServiceEntry) && string.Equals(PriceId, other.PriceId) &&
                   string.Equals(AlgoName, other.AlgoName) && string.Equals(Name, other.Name) &&
                   UseWindow.Equals(other.UseWindow) && MinProfit == other.MinProfit && Hashrate == other.Hashrate &&
                   Power == other.Power && string.Equals(Priority, other.Priority) && Affinity == other.Affinity &&
                   string.Equals(Folder, other.Folder) && string.Equals(Command, other.Command) &&
                   string.Equals(Arguments, other.Arguments) && string.Equals(DonationFolder, other.DonationFolder) &&
                   string.Equals(DonationCommand, other.DonationCommand) &&
                   string.Equals(DonationArguments, other.DonationArguments);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hashCode = Id;
                hashCode = (hashCode * 397) ^ (ServiceEntry != null ? ServiceEntry.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (PriceId != null ? PriceId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AlgoName != null ? AlgoName.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ UseWindow.GetHashCode();
                hashCode = (hashCode * 397) ^ MinProfit.GetHashCode();
                hashCode = (hashCode * 397) ^ Hashrate.GetHashCode();
                hashCode = (hashCode * 397) ^ Power.GetHashCode();
                hashCode = (hashCode * 397) ^ (Priority != null ? Priority.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Affinity;
                hashCode = (hashCode * 397) ^ (Folder != null ? Folder.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Command != null ? Command.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Arguments != null ? Arguments.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DonationFolder != null ? DonationFolder.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DonationCommand != null ? DonationCommand.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (DonationArguments != null ? DonationArguments.GetHashCode() : 0);
                return hashCode;
            }
        }
    }
}