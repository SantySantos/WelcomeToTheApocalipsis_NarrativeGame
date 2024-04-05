using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace OOP_PROJECT.Main_Character_Description
{
    internal class MaleCharacters : Characters
    {
        public override string Name { get; set; }
        public override double hp { get; set; }
        public override int gold { get; set; }
        public override string Weapon { get; set; }
        public void GeneralMaleDescription()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hello, I am Kairos");
            Console.WriteLine($"HP: 120");
            Console.WriteLine($"Gold : 100");
            Console.WriteLine($"Weapon : Axe (10 damage)");
        }
    }
    internal class FemaleCharacters : Characters
    {
        public override string Name { get; set; }
        public override double hp { get; set; }
        public override int gold { get; set; }
        public override string  Weapon {get; set; }
        public void GeneralFemaleDescription()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Hello, I am Aria");
            Console.WriteLine($"HP: 100");
            Console.WriteLine($"Gold : 100");
            Console.WriteLine($"Weapon : Axe (10 damage)");

        }
    }
}
