namespace Task.Shop.Pawns
{
    internal sealed class Seller : Pawn
    {
        public Seller(string name, int money) : base(name, money) 
        {
            ItemsToSell = new Inventory();
        }

        public Inventory ItemsToSell { get; init; }
    }
}
