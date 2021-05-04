namespace Builder_Pattern
{
    class Bow : Weapon
    {
        public Bow()
        {
            Damage = 8;
            Defense = 0;
        }

        public override string ToString() => "Bow";
    }
}