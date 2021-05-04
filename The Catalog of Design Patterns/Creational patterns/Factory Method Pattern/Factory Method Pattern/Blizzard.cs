namespace Factory_Method_Pattern
{
    class Blizzard : Spell
    {
        public Blizzard()
        {
            MPCost = 80;
        }

        public override string ToString()
        {
            return $"Blizzard - {MPCost} MP";
        }
    }
}