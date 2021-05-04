namespace Factory_Method_Pattern
{
    class Frostbolt : Spell
    {
        public Frostbolt()
        {
            MPCost = 8;
        }

        public override string ToString()
        {
            return $"Frostbolt - {MPCost} MP";
        }
    }
}