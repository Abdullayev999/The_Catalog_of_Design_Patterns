namespace Builder_Pattern
{
    class ClothArmor : Armor
    {
        public ClothArmor()
        {
            Defense = 2;
        }

        public override string ToString() => "Cloth";
    }
}