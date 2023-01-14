namespace Task.Shop.Products
{
    internal class Drink : Item
    {
        public Drink(string name, int price, string description, float volume) : base(name, price, description)
        {
            Volume = volume;
        }

        public float Volume { get; protected set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Write($" Объём - {Volume} л.");
        }
    }
}
