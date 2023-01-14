namespace Task.Shop.Pawns
{
    internal sealed class Player : Pawn
    {
        public Player(string name, int money) : base(name, money)
        {
            Inventory = new Inventory();
        }

        public Inventory Inventory { get; init; }
    }
}
