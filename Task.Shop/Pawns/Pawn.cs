namespace Task.Shop.Pawns
{
    internal abstract class Pawn
    {
        protected Inventory Inventory;

        public Pawn(string name, int money)
        {
            Name = name;
            Money = money;
            Inventory = new Inventory();
        }

        public string Name { get; protected set; }
        public int Money { get; protected set; }

        public virtual void BuyItem(in Item itemOnSale)
        {
            Money -= itemOnSale.Price;
            Inventory.AddItem(itemOnSale);
        }

        public virtual void ShowItemsInventory()
        {
            Inventory.ShowAllItems();
        }
    }
}
