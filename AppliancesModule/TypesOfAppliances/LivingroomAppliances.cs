namespace AppliancesModule.TypesOfAppliances
{
    public abstract class LivingRoomAppliances : ElectricAppliance
    {
        protected LivingRoomAppliances(string name, int yearOfCreation, double voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public override void FunctionOfAppliance()
        {
            Console.WriteLine("These appliances are used for entertainment or cleaning");
        }
    }
}
