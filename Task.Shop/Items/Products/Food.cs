namespace Task.Shop.Products
{
    internal class Food : Item
    {
        public Food(string name, int price, string description, string freshness) : base(name, price, description)
        {
            Freshness = freshness;
        }

        public string Freshness { get; protected set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Write($" Свежесть - {Freshness}");
        }
    }
}
