using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using OOP_PROJECT;
using OOP_PROJECT.Main_Character_Description;
using System.Net.Security;
using FINAL_PROJECT_GV5.Places;

namespace OOP_PROJECT.Places
{

    internal class MainStore : Place
    {
        
        internal override string Description()
        {

            Title();
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gold:" + MainCharacter.gold);
            Console.ResetColor();
            return @"STORE
1. Fruits, regenarates 10 hp - 10 gold
2. Super fruits, regerates 40 hp - 38 gold
3. Mega fruits, regenerates 100 hp - 60- gold
4. Betting Coins, bet an amount of money, double it or lose it all - 10 gold
5. go back to refugee


What option do you pick(write the number)?";

        }
        public void SucessfulPurchase()
        {
            Title();
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gold:" + MainCharacter.gold);
            Console.ResetColor();
            Console.WriteLine("STORE");
            Console.WriteLine("1. Fruits, regenarates 10 hp - 10 gold ");
            Console.WriteLine("2. Super fruits, regenerates 50 hp - 38 gold");
            Console.WriteLine("3. Mega fruits, regenerates 100 hp - 60- gold");
            Console.WriteLine("4. Betting Coins, bet an amount of money, double it or lose it all - 10 gold");
            Console.WriteLine("5. go back to refugee");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("What option do you pick(write the number)?");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Sucessful Purchase !!!");
            Console.ResetColor();
            Thread.Sleep(1000);
            Console.Clear();
        }
        public bool GoldReturn(int price)
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;

            if (MainCharacter.gold - price >= 0)
            {
                MainCharacter.gold -= price;
                SucessfulPurchase();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal override void MovingAround(string choice2)
        {
            var inventory = new Inventory();
            switch (choice2)
            {
                case "1":
                    
                    if(GoldReturn(10) == true)
                    {
                        inventory.BuyingFruits();                       
                        
                    }
                    else if (GoldReturn(10) == false)
                    {
                        Console.WriteLine("You dont have enough Money");
                    }

                    break;
                case "2":
                    if (GoldReturn(38) == true)
                    {
                        inventory.BuyingSuperFruits();
                       
                       
                        
                    }
                    else if(GoldReturn(38) == false)
                    {
                        Console.WriteLine("You dont have enough Money");
                        
                    }

                    break;
                case "3":
                    if (GoldReturn(60) == true)
                    {
                        inventory.BuyingMegaFruits();

                    }
                    else if (GoldReturn(38) == false)
                    {
                        Console.WriteLine("You dont have enough Money");

                    }


                    break;
                case "4":
                    if (GoldReturn(10) == true)
                    {
                        inventory.BettingCoins();

                    }
                    else if (GoldReturn(10) == false)
                    {
                        Console.WriteLine("You dont have enough Money");
                    }
                    break;
                case "5":
                    Console.Clear();
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
           
        }
        internal void Title()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************************************");
            Console.WriteLine("*                 THE STORE                *");
            Console.WriteLine("********************************************");
            Console.ResetColor(); 
            Console.WriteLine();

        }
    }
}

