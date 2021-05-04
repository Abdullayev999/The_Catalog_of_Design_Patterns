namespace Factory_Method_Pattern
{
    class Resurrect : Spell
    {
        public Resurrect()
        {
            MPCost = 50;
        }

        public override string ToString()
        {
            return $"Resurrect - {MPCost} MP";
        }
    }
}