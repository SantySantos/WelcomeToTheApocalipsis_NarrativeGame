using OOP_PROJECT;
using OOP_PROJECT.Places;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FINAL_PROJECT_GV5.Places;
using System.Threading.Channels;
using System;
using System.ComponentModel.Design;
using System.Transactions;
using OOP_PROJECT.Main_Character_Description;

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
            if(Game.Firstskull == true)
            {
                Console.WriteLine("4. 1 SKULL");
            }
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
            Characters MainCharacter = Switch.MainCharacter;
            switch (choice2)
            {
                case "1":
                    if(Fruits > 0)
                    {
                        UsingFruits();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You healed !!  Current HP: " +  MainCharacter.hp); Console.WriteLine();
                        Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You healed !!  Current HP: " + MainCharacter.hp); Console.WriteLine();
                        Console.ResetColor();
                    }
                   
                    else
                    {
                        Console.WriteLine("You dont have enough Coins");
                    }
                    
                    break;
                case "3":                   
                    if (MainCharacter.gold <= 0)
                    {
                        Console.WriteLine("You dont have gold to bet");
                        Thread.Sleep(1500);
                        Game.Transition<Inventory>();
                    }
                    else if (Coins > 0)
                    {
                        Betting();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Total Gold: " + MainCharacter.gold); Console.WriteLine();
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("You dont have enough Coins");
                    }
                    break;
                case "4":
                    Console.WriteLine("Current Weapon: " + MainCharacter.Weapon);
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
            return MainCharacter.hp += 10;
        }
        public double UsingSuperFruits() 
        {
            Characters MainCharacter = Switch.MainCharacter;
            SuperFruits -= 1;
            return MainCharacter.hp += 40;
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
            while (true)
            {
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Current Gold: " + MainCharacter.gold);
                Console.ResetColor();
                if (MainCharacter.gold <= 0) 
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
                Console.WriteLine();
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
                            MainCharacter.gold -= goldy;
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

