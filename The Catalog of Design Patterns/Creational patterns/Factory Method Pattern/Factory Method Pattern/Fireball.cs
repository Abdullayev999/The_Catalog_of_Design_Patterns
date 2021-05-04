namespace Factory_Method_Pattern
{
    class Fireball : Spell
    {
        public Fireball()
        {
            MPCost = 5;
        }

        public override string ToString()
        {
            return $"Fireball - {MPCost} MP";
        }
    }
}