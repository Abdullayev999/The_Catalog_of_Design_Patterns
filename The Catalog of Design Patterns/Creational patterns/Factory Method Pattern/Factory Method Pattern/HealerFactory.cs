namespace Factory_Method_Pattern
{
    class HealerFactory : IWizzardFactory
    {
        public Wizzard Create()
        {
            Wizzard wizzard = new Healer();
            wizzard.Spells.Add(new Heal());
            wizzard.Spells.Add(new Resurrect());
            wizzard.Spells.Add(new Fireball());
            return wizzard;
        }
    }
}