namespace Builder_Pattern
{
    abstract class PlayerBuilder
    {
        protected Player player;

        public PlayerBuilder()
        {
            player = new Player();
        }

        public abstract void EquipRightHand();
        public abstract void EquipLeftHand();
        public abstract void EquipHead();
        public abstract void EquipChest();
        public abstract void EquipLegs();

        public Player Build()
        {
            return player;
        }
    }
}