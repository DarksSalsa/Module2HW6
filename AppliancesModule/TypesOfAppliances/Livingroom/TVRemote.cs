namespace AppliancesModule.TypesOfAppliances.Livingroom
{
    using AppliancesModule.TypesOfAppliances.Interfaces;

    internal class TVRemote : LivingRoomAppliances, IWaterproofAppliance
    {
        private int _tuningMode;

        public TVRemote(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
            _tuningMode = Random.Shared.Next(1000, 100000);
        }

        public int TuningMode
        {
            get { return _tuningMode; }
        }

        public void Tune()
        {
            _tuningMode = Random.Shared.Next(1000, 100000);
        }
    }
}
