namespace AppliancesModule.Services
{
    using AppliancesModule.TypesOfAppliances.Interfaces;

    public static class FloodSurvivorsFinder
    {
        public static void Flood(this ElectricAppliance[] devices)
        {
            Console.WriteLine("These are the items in your flat: ");
            foreach (var device in devices)
            {
                Console.Write($"{device.Name} ");
            }

            Console.WriteLine();
            Console.WriteLine("These devices will survive the flood: ");
            foreach (var i in devices)
            {
                if (i is IWaterproofAppliance)
                {
                    Console.Write($"{ i.Name} ");
                }
            }

            Console.WriteLine();
        }
    }
}
