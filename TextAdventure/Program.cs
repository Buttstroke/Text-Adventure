using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your character name?");
            string name = Console.ReadLine();
            Hero Buttstroke = new Hero(name);
            Console.WriteLine("What is your character race?");
            string race = Console.ReadLine();
            Buttstroke.Race = race;
            Console.WriteLine("What is your character class?");
            string heroclass = Console.ReadLine();
            Buttstroke.HeroClass = heroclass;
            AttributeGenerator at = new AttributeGenerator();
            Buttstroke = at.Generate(Buttstroke);

            Console.WriteLine(Buttstroke.ToString());



            Console.ReadKey();
        }
    }
}
