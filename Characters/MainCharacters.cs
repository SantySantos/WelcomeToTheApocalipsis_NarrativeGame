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
        public override int damage { get; set; } = 200;
        public void GeneralMaleDescription()
        {
            Console.WriteLine();
            Console.WriteLine("-------------------------------");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hello, I am Kairos (Easy)");
            Console.WriteLine($"HP: 500");
            Console.WriteLine($"Gold : 1000");
            Console.WriteLine($"Weapon : Sword (200 damage)");

        }
    }
    internal class FemaleCharacters : Characters
    {
        public override string Name { get; set; }
        public override double hp { get; set; }
        public override int gold { get; set; }
        public override string  Weapon {get; set; }
        public override int damage { get; set; } = 100;
        public void GeneralFemaleDescription()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Hello, I am Aria (Medium)");
            Console.WriteLine($"HP: 200");
            Console.WriteLine($"Gold : 500");
            Console.WriteLine($"Weapon : Arch (100 damage)");

        }

    }
    internal class ThirdCharacter : Characters
    {
        public override string Name { get; set;}
        public override double hp { get; set; }
        public override int gold { get; set; }
        public override string Weapon { get; set;}
        public override int damage { get; set; } = 10;
        public void generalThirdCharacterDescription()
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Hello, I am Nova (Hard)");
            Console.WriteLine($"HP: 40");
            Console.WriteLine($"Gold : 100");
            Console.WriteLine($"Weapon : Axe (10 damage)");

        }
    }
}
