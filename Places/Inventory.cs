using OOP_PROJECT;
using OOP_PROJECT.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.Main_Character_Description;

namespace FINAL_PROJECT_GV5.Places
{
    internal class Inventory : Place
    {
        internal override string Description()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVENTORY");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ITEMS");
            Console.ResetColor();
            Console.WriteLine("1. Fruits");
            Console.WriteLine("2. Super Fruits");
            Console.WriteLine("3. Chocolate Bar");
            Console.WriteLine("4. 70/20 Chance");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("WEAPONS");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What would you like to use?");
            Console.WriteLine();
            Console.WriteLine("Come back to the [refugee]");

            return "";
        }
        internal override void MovingAround(string choice2)
        {
            switch (choice2)
            {
                case "1":
                    UsingFruits();
                    break;
                case "2":
                    UsingSuperFruits();
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "refugee":
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
        public double UsingFruits()
        {
            Characters MainCharacter = Switch.MainCharacter;
            return MainCharacter.hp += 5;
        }
        public double UsingSuperFruits() 
        {
            Characters MainCharacter = Switch.MainCharacter;
            return MainCharacter.hp += 38;
        }
    }
}

