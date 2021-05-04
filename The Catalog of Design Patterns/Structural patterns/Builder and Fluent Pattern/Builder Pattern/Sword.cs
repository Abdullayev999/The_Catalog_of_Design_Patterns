namespace Builder_Pattern
{
    class Sword : Weapon
    {
        public Sword()
        {
            Damage = 10;
            Defense = 2;
        }

        public override string ToString() => "Sword";
    }
}