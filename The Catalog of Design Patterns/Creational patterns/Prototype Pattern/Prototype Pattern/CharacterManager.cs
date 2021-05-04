using System.Collections.Generic;

namespace Prototype_Pattern
{
    class CharacterManager
    {
        private Dictionary<CharacterClass, Character> presets;

        public CharacterManager()
        {
            presets = new Dictionary<CharacterClass, Character>();
            presets.Add(CharacterClass.Warrior, new Character()
            {
                HP = 200,
                MP = 0,
                Strength = 10,
                Dexterity = 5,
                Intellect = 2
            });

            presets.Add(CharacterClass.Thief, new Character()
            {
                HP = 120,
                MP = 50,
                Strength = 4,
                Dexterity = 10,
                Intellect = 5
            });

            presets.Add(CharacterClass.Mage, new Character()
            {
                HP = 80,
                MP = 120,
                Strength = 2,
                Dexterity = 3,
                Intellect = 10
            });
        }

        public Character this[CharacterClass cls]
        {
            get { return presets[cls].Clone() as Character; }
        }
    }
}
