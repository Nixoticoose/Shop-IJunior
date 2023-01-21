namespace Task.Shop.Pawns
{
    internal sealed class Seller : Pawn
    {
        public Seller(string name, int money) : base(name, money) { }

        public bool TryGetItemByIndex(int indexItem, out Item itemToSell)
        {
            return _inventory.TryGetItemByIndex(indexItem, out itemToSell);
        }

        public void AddItemToSell(in Item item)
        {
            _inventory.AddItem(item);
        }
    }
}
