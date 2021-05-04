namespace Builder_Pattern
{
    class LeatherArmor : Armor
    {
        public LeatherArmor()
        {
            Defense = 5;
        }

        public override string ToString() => "Leather";
    }
}