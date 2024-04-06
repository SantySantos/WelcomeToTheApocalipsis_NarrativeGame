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
3. You might receive random hits wich damage 20HP 
4. Press the spacebar as fast as you can to earn more gold!
5. You might Find SKULLS, it is not easy tho
6. Press L to leave the forest.
6. If you die, game is over.

HAVE FUN

press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        internal int CollectingGold()
        {
            
           ConsoleKeyInfo Spacebar = Console.ReadKey(true);
           Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;          
           MainCharacter.gold -= 20;
            do
            {
                if (Spacebar.Key == ConsoleKey.Spacebar)
                {
                    count++;
                    if (count == 10)
                    {
                        MainCharacter.gold += 2;
                        Console.WriteLine("Gold +2"); 
                        count = 0;
                    }
                    Spacebar = Console.ReadKey(false);
                    Task.Delay(100).Wait();
                }
            }while(Spacebar.Key != ConsoleKey.L);

            
            PrintingWaitingTime();
                   
            return MainCharacter.gold;
        }
        internal void PrintingWaitingTime()
        {
            Console.WriteLine("Leaving the forest...");
            for (int i  = 0; i < 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.Clear();
            Game.Transition<Refugee>();
        }
    }
}
