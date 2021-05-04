namespace Abstract_Factory_Animal
{
    public class Bison : Herbivore
    {
        public override void Eating()
        {
            Weight += random.Next(4, 6);
        }
        public override string ToString()
        {
            return $"Bison Weight : {Weight} , IsLive : {isLive} (Herbivore)";
        }
    }
}
