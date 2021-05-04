namespace Factory_Method_Pattern
{
    class WarlockFactory : IWizzardFactory
    {
        public Wizzard Create()
        {
            Wizzard wizzard = new Warlock();
            wizzard.Spells.Add(new Fireball());
            wizzard.Spells.Add(new Frostbolt());
            wizzard.Spells.Add(new Firestorm());
            wizzard.Spells.Add(new Blizzard());
            return wizzard;
        }
    }
}