using System.Collections.Generic;

namespace Abstract_Factory_Warcraft
{
    class UnitCreator
    {
        public IUnitFactory UnitFactory { get; set; }

        public void AddWarrior(List<Unit> units)
        {
            units.Add(UnitFactory.CreateWarrior());
        }

        public void AddRanger(List<Unit> units)
        {
            units.Add(UnitFactory.CreateRanger());
        }
    }
}