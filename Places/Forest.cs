using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OOP_PROJECT.Places
{
    internal class Forest : Place
    {
        private static int count = 0;
        internal override string Description()
        {
            Instructions();
            return @"Press 1 to join the forest or 2 to come back to the refugee";
        }

        internal override void MovingAround(string choice2)
        {
            switch (choice2)
            {
                case "1":
                    CollectingGold();
                    break;
                case "2":
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Please choose a valid option");
                    break;
            }
        }
        internal void Instructions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("INSTRUCTIONS");
            Console.ResetColor();
            Console.WriteLine(@"In the forest, you will need to 
collect gold to be able to buy things in the store, while you are there, you will be receiving
constant damage, these are the rules:

1. You will need to pay 20 gold to join the forest
2. It wil take you 10 seconds without being able to do anything to leave the forest
3. You might Find SKULLS, it is not easy tho
4. Press ENTER to start the forest.
5. Press SPACEBAR to leave the forest.
6. If you die, game is over.

ENJOY, AND HAVE GOOD TIMING :D

HAVE FUN

press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal int CollectingGold()
        {

            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            MainCharacter.gold -= 20;
            ConsoleKeyInfo KeyInfo = Console.ReadKey(true);
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Current HP: " + MainCharacter.hp + "         ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Current Gold: " + MainCharacter.gold);
                Console.WriteLine();
                Console.ResetColor();
                Thread.Sleep(1500);
                MainCharacter.gold += 3;
                FinishingInTheForest();
                if (KeyInfo.Key == ConsoleKey.Spacebar)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
            PrintingWaitingTime();
                   
            return MainCharacter.gold;
        }
        internal void PrintingWaitingTime()
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;           
            Console.WriteLine("Leaving the forest...");
            MainCharacter.hp -= 1;
            for (int i  = 0; i < 10; i++)
            {
                Console.WriteLine(i + "     Current HP:"  + MainCharacter.hp);
                if (MainCharacter.hp <= 0)
                {
                    Game.Finish();
                }
                Thread.Sleep(1000);
            }                      
            Console.Clear();
            Game.Transition<Refugee>();
        }
       public async void FinishingInTheForest()
       {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            if (MainCharacter.hp <= 0)
            {
                Game.Finish();                
            }
            else
            {
                MainCharacter.hp -= 1;
                await Task.Delay(500);
            }
       }
    }
}
