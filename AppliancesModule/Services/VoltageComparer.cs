namespace AppliancesModule.Services
{
    public class VoltageComparer : IComparer<ElectricAppliance>
    {
        public int Compare(ElectricAppliance? x, ElectricAppliance? y)
        {
            return (int)(x.Voltage - y.Voltage);
        }
    }
}
