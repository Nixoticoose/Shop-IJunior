namespace Task.Shop.Weapons
{
    internal abstract class Weapon : Item
    {
        public Weapon(string name, int price, string description, float damage) : base(name, price, description)
        {
            Damage = damage;
        }

        public float Damage { get; protected set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Write($" Урон: {Damage}.");
        }
    }
}
