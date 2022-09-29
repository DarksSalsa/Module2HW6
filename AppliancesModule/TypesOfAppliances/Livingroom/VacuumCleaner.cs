namespace AppliancesModule.TypesOfAppliances.Livingroom
{
    public class VacuumCleaner : LivingRoomAppliances
    {
        public VacuumCleaner(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public void Clean()
        {
            Console.WriteLine("I've cleaned some dust from the floor.");
        }
    }
}
