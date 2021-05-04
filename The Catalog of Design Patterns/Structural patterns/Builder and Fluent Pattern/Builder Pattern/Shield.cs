namespace Builder_Pattern
{
    class Shield : Weapon
    {
        public Shield()
        {
            Damage = 1;
            Defense = 10;
        }

        public override string ToString() => "Shield";
    }
}