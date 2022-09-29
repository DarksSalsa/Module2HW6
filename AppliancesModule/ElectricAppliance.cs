namespace AppliancesModule
{
    public abstract class ElectricAppliance
    {
        private string _name;
        private int _yearOfCreation;
        private double _voltage;

        protected ElectricAppliance(string name, int yearOfCreation, double voltage)
        {
            _name = name;
            _yearOfCreation = yearOfCreation;
            _voltage = voltage;
        }

        public string Name
        {
            get { return _name; }
        }

        public int YearOfCreation
        {
            get { return _yearOfCreation; }
        }

        public virtual double Voltage
        {
            get { return _voltage; }
        }

        public abstract void FunctionOfAppliance();
    }
}