namespace AppliancesModule.TypesOfAppliances
{
    public abstract class KitchenAppliances : ElectricAppliance
    {
        protected KitchenAppliances(string name, int yearOfCreation, double voltage)
            : base(name, yearOfCreation, voltage + CalculateRealVoltage(voltage, yearOfCreation))
        {
        }

        public override void FunctionOfAppliance()
        {
            Console.WriteLine("These appliances are used for storing or preparing food and dishes");
        }

        private static double CalculateRealVoltage(double voltage, int yearOfCreation)
        {
            double realConsumption = (DateTime.Now.Year - yearOfCreation) * 0.4 * voltage;
            return realConsumption;
        }
    }
}
