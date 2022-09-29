namespace AppliancesModule.TypesOfAppliances.Livingroom
{
    public class TV : LivingRoomAppliances
    {
        private readonly TVRemote _remote;
        private bool _economyMode;

        public TV(string name, int yearOfCreation, double voltage, bool economyMode)
            : base(name, yearOfCreation, voltage * TV.RealVoltage(yearOfCreation, economyMode))
        {
            EconomyMode = economyMode;
            _remote = new (name, yearOfCreation, Random.Shared.Next(1, 5));
        }

        public bool EconomyMode
        {
            get { return _economyMode; }

            init { _economyMode = value;  }
        }

        public void ChannelFrequency()
        {
            Console.WriteLine($"TV is on channel with frequency {_remote.TuningMode}");
        }

        public void SwitchChannel()
        {
            _remote.Tune();
        }

        private static double RealVoltage(int yearOfCreation, bool mode)
        {
            if (mode)
            {
                double rv = 0.1 * (1 + DateTime.Now.Year - yearOfCreation);
                return rv;
            }
            return 1;
        }
    }
}
