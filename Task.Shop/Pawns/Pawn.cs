namespace Task.Shop.Pawns
{
    internal abstract class Pawn
    {
        protected Inventory _inventory;

        public Pawn(string name, int money)
        {
            Name = name;
            Money = money;
            _inventory = new Inventory();
        }

        public string Name { get; protected set; }
        public int Money { get; protected set; }

        public virtual void SellItem(in Item itemOnSale)
        {
            Money += itemOnSale.Price;
            _inventory.RemoveItem(itemOnSale);
        }

        public virtual void BuyItem(in Item itemOnSale)
        {
            Money -= itemOnSale.Price;
            _inventory.AddItem(itemOnSale);
        }

        public virtual void ShowItemsInventory()
        {
            _inventory.ShowAllItems();
        }
    }
}
