namespace Abstract_Factory_Warcraft
{
    public interface IUnitFactory
    {
        Warrior CreateWarrior();
        Ranger CreateRanger();

    }
}