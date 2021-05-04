namespace Abstract_Factory_Warcraft
{
    class HumanFactory : IUnitFactory
    {
        public Warrior CreateWarrior()
        {
            return new Footman();
        }

        public Ranger CreateRanger()
        {
            return new Archer();
        }
    }
}