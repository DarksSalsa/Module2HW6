namespace AppliancesModule.TypesOfAppliances
{
    public abstract class BathroomAppliances : ElectricAppliance
    {
        protected BathroomAppliances(string name, int yearOfCreation, double voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public virtual void Drying()
        {
            Console.Write("I dry clother in this way: ");
        }

        public override void FunctionOfAppliance()
        {
            Console.WriteLine("These appliances are used for working with clothes");
        }
    }
}
