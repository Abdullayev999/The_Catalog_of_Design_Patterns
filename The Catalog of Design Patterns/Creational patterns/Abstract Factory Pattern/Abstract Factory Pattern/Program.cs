using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Channels;

namespace Abstract_Factory_Warcraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();
            UnitCreator unitCreator = new UnitCreator();
            unitCreator.UnitFactory = new OrcFactory();

            unitCreator.AddWarrior(units);
            unitCreator.AddWarrior(units);
            unitCreator.AddWarrior(units);

            unitCreator.AddRanger(units);
            unitCreator.AddRanger(units);


            unitCreator.UnitFactory = new HumanFactory();

            unitCreator.AddWarrior(units);
            unitCreator.AddWarrior(units);
            unitCreator.AddWarrior(units);

            unitCreator.AddRanger(units);
            unitCreator.AddRanger(units);

            foreach (var item in units)
            {
                Console.WriteLine(item);
            }
        }
    }
}
