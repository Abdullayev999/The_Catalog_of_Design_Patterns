namespace Builder_Pattern
{
    class BerserkerBuilder : PlayerBuilder
    {
        public override void EquipRightHand()
        {
            player.RightHand = new Sword();
        }

        public override void EquipLeftHand()
        {
            player.LeftHand = new Sword();
        }

        public override void EquipHead()
        {
            player.Head = new LeatherArmor();
        }

        public override void EquipChest()
        {
            player.Chest = new LeatherArmor();
        }

        public override void EquipLegs()
        {
            player.Legs = new LeatherArmor();
        }
    }
}