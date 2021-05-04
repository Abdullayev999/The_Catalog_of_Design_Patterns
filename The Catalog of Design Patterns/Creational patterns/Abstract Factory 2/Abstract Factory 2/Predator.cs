namespace Abstract_Factory_Animal
{
    public abstract class Predator : Animal
    {
        public int Power { get; set; }
        public abstract void Hunting(Herbivore herbivore);
    } 
}
