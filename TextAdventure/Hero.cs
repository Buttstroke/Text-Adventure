using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    public class Hero
    {
        public Hero()
        {

        }
        public Hero(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Race { get; set; }
        public string HeroClass { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Wisdom { get; set; }
        public int Intelligence { get; set; }
        public int Charisma { get; set; }
        public int Constitution { get; set; }
        public int Hitpoints { get; set; }

        public override string ToString()
        {
            return @"Name: " + Name +
                "\n Dexterity= " + Dexterity
                + "\n Strength= " + Strength;
        }
    }
}
