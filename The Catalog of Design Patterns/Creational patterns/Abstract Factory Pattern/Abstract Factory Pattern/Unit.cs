namespace Abstract_Factory_Warcraft
{
    public abstract class Unit
    {
        public int HP { get; set; }
        public int Damage { get; set; }
        abstract public void Attack(Unit target);
    }
}