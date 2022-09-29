namespace AppliancesModule.TypesOfAppliances.Bathroom
{
    using AppliancesModule.TypesOfAppliances.Interfaces;

    public class WashingMachine : BathroomAppliances, IWaterproofAppliance
    {
        public WashingMachine(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public override void Drying()
        {
            base.Drying();
            Console.WriteLine("By centrifuging them.");
        }
    }
}
