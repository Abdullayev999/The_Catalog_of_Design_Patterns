namespace Builder_Pattern
{
    class HomelessBuilder : PlayerBuilder
    {
        public override void EquipRightHand()
        {
            player.RightHand = null;
        }

        public override void EquipLeftHand()
        {
            player.LeftHand = null;
        }

        public override void EquipHead()
        {
            player.Head = null;
        }

        public override void EquipChest()
        {
            player.Chest = new ClothArmor();
        }

        public override void EquipLegs()
        {
            player.Legs = new ClothArmor();
        }
    }
}