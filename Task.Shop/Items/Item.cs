namespace Task.Shop
{
    internal abstract class Item
    {
        public Item(string name, int price, string description)
        {
            Name = name;
            Price = price;
            Description = description;
        }

        public string Name { get; init; }
        public int Price { get; protected set; }
        public string Description { get; protected set; }

        public virtual void ShowInfo()
        {
            Write($"{Name}, цена - {Price}, описание предмета - {Description}");
        }
    }
}
