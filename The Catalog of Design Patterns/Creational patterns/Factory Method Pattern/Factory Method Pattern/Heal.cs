namespace Factory_Method_Pattern
{
    class Heal :Spell
    {
        public Heal()
        {
            MPCost = 10;
        }

        public override string ToString()
        {
            return $"Heal - {MPCost} MP";
        }
    }
}