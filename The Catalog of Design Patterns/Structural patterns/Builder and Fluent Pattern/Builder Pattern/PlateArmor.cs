namespace Builder_Pattern
{
    class PlateArmor : Armor
    {
        public PlateArmor()
        {
            Defense = 10;
        }

        public override string ToString() => "Plate";
    }
}