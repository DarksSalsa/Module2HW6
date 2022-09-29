namespace AppliancesModule.TypesOfAppliances.Bathroom
{
    public class Fan : BathroomAppliances
    {
        public Fan(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public override void Drying()
        {
            base.Drying();
            Console.WriteLine("By blowing water from them.");
        }
    }
}
