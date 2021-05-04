namespace Abstract_Factory_Animal
{
    public class Antelope : Herbivore
    {
        public override void Eating()
        {            
            Weight += random.Next(2, 4);
        }
        public override string ToString()
        {
            return $"Antelope Weight : {Weight} , IsLive : {isLive} (Herbivore)";
        }
    }
}
