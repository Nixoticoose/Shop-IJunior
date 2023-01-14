namespace Task.Shop.Weapons
{
    internal class Knife : Weapon
    {
        public Knife(string name, int price, string description, float damage, float bladeLength) : base(name, price, description, damage)
        {
            BladeLength = bladeLength;
        }

        public float BladeLength { get; protected set; }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Write($" Длина лезвия - {BladeLength}");
        }
    }
}
