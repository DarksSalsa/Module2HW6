namespace AppliancesModule.Services
{
    public static class VoltageSorter
    {
        public static void SortByVoltageArray(this ElectricAppliance[] device)
        {
            Array.Sort(device, new VoltageComparer());
            Console.WriteLine("Sorting by voltage: ");
            foreach (var i in device)
            {
                Console.WriteLine($"{i.Name} - {i.Voltage}");
            }
        }
    }
}
