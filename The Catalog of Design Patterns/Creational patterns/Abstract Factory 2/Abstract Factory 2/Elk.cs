namespace Abstract_Factory_Animal
{
    public class Elk : Herbivore
    {
        public override void Eating()
        {
            Weight = random.Next(3, 5);
        }
        public override string ToString()
        {
            return $"Elk Weight : {Weight} , IsLive : {isLive} (Herbivore)";
        }
    }
}
