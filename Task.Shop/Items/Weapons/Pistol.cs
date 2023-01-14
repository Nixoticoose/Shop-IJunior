namespace Task.Shop.Weapons
{
    internal class Pistol : Weapon
    {
        public Pistol(string name, int price, string description, float damage, int countBullets) : base(name, price, description, damage)
        {
            CountBullets = countBullets;
        }

        public int CountBullets { get; protected set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Write($" Количество патронов в магазине: {CountBullets}");
        }
    }
}
