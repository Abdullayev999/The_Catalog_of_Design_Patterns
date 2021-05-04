namespace Builder_Pattern
{
    class WarriorBuilder : PlayerBuilder
    {
        public override void EquipRightHand()
        {
            player.RightHand = new Sword();
        }

        public override void EquipLeftHand()
        {
            player.LeftHand = new Shield();
        }

        public override void EquipHead()
        {
            player.Head = new PlateArmor();
        }

        public override void EquipChest()
        {
            player.Chest = new PlateArmor();
        }

        public override void EquipLegs()
        {
            player.Legs = new PlateArmor();
        }
    }
}