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

        public virtual void WithdrawMoney(int money)
        {
            Money -= money;
        }

        public virtual void AddMoney(int money)
        {
            Money += money;
        }
    }
}
