namespace Task.Shop.Pawns
{
    internal sealed class Seller : Pawn
    {
        public Seller(string name, int money) : base(name, money) { }

        public bool TryGetItemByIndex(int indexItem, out Item itemToSell)
        {
            return Inventory.TryGetItemByIndex(indexItem, out itemToSell);
        }

        public void SellItem(in Item itemOnSale)
        {
            Money += itemOnSale.Price;
            Inventory.RemoveItem(itemOnSale);
        }

        public void AddItemToSell(in Item item)
        {
            Inventory.AddItem(item);
        }
    }
}
