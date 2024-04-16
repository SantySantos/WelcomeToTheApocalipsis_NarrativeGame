using OOP_PROJECT;
using OOP_PROJECT.Places;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.Main_Character_Description;
using System.Threading.Channels;
using System;
using System.ComponentModel.Design;

namespace FINAL_PROJECT_GV5.Places
{
    internal class Inventory : Place
    {
        static double Fruits = 0;
        static double SuperFruits = 0;
        static int Coins = 0;

        internal override string Description()
        {

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INVENTORY");
            Console.WriteLine();
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ITEMS");
            Console.ResetColor();
            Console.WriteLine("1. Fruits: " + Fruits);
            Console.WriteLine("2. Super Fruits: " + SuperFruits);
            Console.WriteLine("3. Coins: " + Coins);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("What would you like to use?");
            Console.WriteLine();
            Console.WriteLine("Come back to the [refugee]");
            Console.ResetColor();

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
                    if(Coins > 0)
                    {
                        Betting();
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough Coins");
                    }
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
        public double BettingCoins()
        {
            Coins += 1;
            return Coins;
        }

        public int Betting()
        {
            Characters MainCharacter = Switch.MainCharacter;
            int goldy;
            int answer;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Currect gold: " + MainCharacter.gold);
            Console.ResetColor();
            while (true)
            {
                if(MainCharacter.gold <= 0) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You dont have money to bet");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                    Console.Clear();
                    Game.Transition<Inventory>();
                }
                while (true)
                {
                    Console.WriteLine("Please insert how much gold you want to bet");
                    string gain = Console.ReadLine();
                    if (int.TryParse(gain, out goldy))
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please type a number");
                        Console.ResetColor();
                    }
                }
                Console.Write("You will bet: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(goldy);
                Console.Write(" GOLD");
                Console.ResetColor();
                Console.WriteLine("Press [1] to bet or [2] to come back to the Inventory");
                Console.WriteLine(); 
                answer = int.Parse(Console.ReadLine());
                switch (answer)
                {

                    case 1:
                        Random random = new Random();
                        if (random.Next(2) == 1)
                        {
                            Console.ForegroundColor= ConsoleColor.Yellow;
                            Console.WriteLine("YOU WON");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Game.Transition<Inventory>();
                            Coins -= 1;
                            return MainCharacter.gold = MainCharacter.gold + (goldy * 2);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("YOU LOSE");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.Clear();
                            Game.Transition<Inventory>();
                            Coins -= 1;
                            return MainCharacter.gold = MainCharacter.gold - goldy;
                        }
                    case 2:
                        Console.Clear();
                        Game.Transition<Inventory>();
                        break;
                    default: Console.WriteLine("Choose a valid option");
                        break;
                }
            }
           
        }
    }
}

