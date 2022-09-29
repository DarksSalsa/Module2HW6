namespace AppliancesModule.TypesOfAppliances.Kitchen
{
    public class Fridge : KitchenAppliances
    {
        private string[] _storage = new string[20];

        public Fridge(string name, int yearOfCreation, int voltage)
            : base(name, yearOfCreation, voltage)
        {
        }

        public string[] Storage
        {
            get { return _storage; }
        }

        public void Add(string product)
        {
            for (int i = 0; i < Storage.Length; i++)
            {
                if (Storage[i] == default)
                {
                    _storage[i] = product;
                    return;
                }
            }

            Console.WriteLine("Fridge is full");
        }
    }
}
