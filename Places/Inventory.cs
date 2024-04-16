using OOP_PROJECT;
using OOP_PROJECT.Places;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.Main_Character_Description;
using System.Threading.Channels;
using System;

namespace FINAL_PROJECT_GV5.Places
{
    internal class Inventory : Place
    {
        static double Fruits = 0;
        static double SuperFruits = 0;

        internal override string Description()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVENTORY");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ITEMS");
            Console.ResetColor();
            Console.WriteLine("1. Fruits: " + Fruits);
            Console.WriteLine("2. Super Fruits: " + SuperFruits);           
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
                    if(Fruits > 0)
                    {
                        UsingFruits();
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough Fruits");
                    }
                    break;
                    
                case "2":
                    if (SuperFruits > 0)
                    { 
                        UsingSuperFruits(); 
                    }
                    else
                    {
                        Console.WriteLine("You dont have SuperFruits");
                    }
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
            Fruits -= 1; 
            return MainCharacter.hp += 5;
        }
        public double UsingSuperFruits() 
        {
            Characters MainCharacter = Switch.MainCharacter;
            SuperFruits -= 1;
            return MainCharacter.hp += 38;
        }

        public double BuyingFruits()
        {
            Fruits += 1;
            return Fruits;
        }

        public double BuyingSuperFruits()
        {
            SuperFruits += 1;
            return SuperFruits;
        }
    }
}

