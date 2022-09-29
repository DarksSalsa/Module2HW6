namespace AppliancesModule.TypesOfAppliances.Kitchen
{
    using AppliancesModule.TypesOfAppliances.Interfaces;

    public class Kettle : KitchenAppliances, IWaterproofAppliance
    {
        private int _milOfWaterInside = 0;

        public Kettle(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public int MilOfWaterInside
        {
            get
            {
                return _milOfWaterInside;
            }
        }

        public void AddWater(int amount)
        {
            _milOfWaterInside += amount;
            if (_milOfWaterInside > 2000)
            {
                Console.WriteLine("Water has overflowed.");
                _milOfWaterInside = 2000;
            }
        }
    }
}
