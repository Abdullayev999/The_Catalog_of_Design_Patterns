namespace Factory_Method_Pattern
{
    class Firestorm : Spell
    {
        public Firestorm()
        {
            MPCost = 50;
        }

        public override string ToString()
        {
            return $"Firestorm - {MPCost} MP";
        }
    }
}