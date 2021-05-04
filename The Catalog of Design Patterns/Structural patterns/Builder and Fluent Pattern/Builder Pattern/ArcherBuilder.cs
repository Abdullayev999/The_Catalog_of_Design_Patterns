namespace Builder_Pattern
{
    class ArcherBuilder : PlayerBuilder
    {
        public override void EquipRightHand()
        {
            player.RightHand = new Bow();
        }

        public override void EquipLeftHand()
        {
            player.LeftHand = null;
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