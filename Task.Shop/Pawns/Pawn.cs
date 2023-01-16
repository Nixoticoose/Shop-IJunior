namespace Task.Shop.Pawns
{
    internal abstract class Pawn
    {
        public Pawn(string name, int money)
        {
            Name = name;
            Money = money;
        }

        public string Name { get; protected set; }
        public int Money { get; protected set; }

        public virtual void WithdrawMoney(in Item itemOnSale)
        {
            Money -= itemOnSale.Price;
        }

        public virtual void AddMoney(in Item itemOnSale)
        {
            Money += itemOnSale.Price;
        }
    }
}
