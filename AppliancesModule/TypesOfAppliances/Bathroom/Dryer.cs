namespace AppliancesModule.TypesOfAppliances.Bathroom
{
    using AppliancesModule.TypesOfAppliances.Interfaces;

    public class Dryer : BathroomAppliances, IWaterproofAppliance
    {
        public Dryer(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public override void Drying()
        {
            base.Drying();
            Console.WriteLine("By heating them.");
        }
    }
}
