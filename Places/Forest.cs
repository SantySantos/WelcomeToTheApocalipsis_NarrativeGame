using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;

namespace OOP_PROJECT.Places
{   
    internal class Forest : Place
    {
        internal override string Description()
        {
            Title();
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
2. It wil take you 5 seconds without being able to do anything to leave the forest
3. You might Find a SKULL, it is not easy tho
4. If you die, game is over.

ENJOY, AND HAVE GOOD TIME :D

HAVE FUN

press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }

        public int askingGold()
        {
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
            int goldy;
            while(true) {
                
                while (true)
                {
                    Title();
                    Console.WriteLine("Please insert how much gold you want to gain, remember, if your Hp reaches 0 you are going to die");
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
                Title();
                Console.Write("You will collect: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(goldy);
                Console.ResetColor();
                Console.Write(" gold, and you will lose: ");
                Console.ForegroundColor= ConsoleColor.Green;
                Console.Write(goldy/10);
                Console.ResetColor();
                Console.Write(" HP, are you sure to proceed?");
                Console.WriteLine();
                Console.WriteLine("Press [1] to start farming or [2] to select again the gold you want to farm");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("REMINDER: YOU ALSO WILL NEED TO PAY 20 GOLD AND WAIT 5 SECS TO LEAVE THE FOREST");
                Console.ResetColor();
                string answer = Console.ReadLine().ToLower() ?? "";
                if (answer == "1")
                {
                    return goldy;
                }
                           
            }
        }

        internal int CollectingGold()
        {
            Random random = new Random();
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
            int WishedGold = askingGold(); 
            mainCharacter.gold -= 20;
            
            for(int i = 0; i < WishedGold; i = i + 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Current HP: " + mainCharacter.hp + "         ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Current Gold: " + mainCharacter.gold);
                Console.WriteLine();
                Console.ResetColor();
                Thread.Sleep(300);
                mainCharacter.gold += 10;
                mainCharacter.hp -= 1;

                if (random.Next(1, 50) == 25)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("+1 SKULL");
                    Game.Firstskull = true;
                    Console.ResetColor();
                }
                if (mainCharacter.hp <= 0)
                {
                    Console.Clear();
                    Game.Finish();
                    break;
                }
            }

            PrintingWaitingTime();
            return mainCharacter.gold;
        }
        internal void PrintingWaitingTime()
        {            
            var story = new ContextStory();
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;           
            Console.WriteLine("Leaving the forest...");
            for (int i  = 0; i < 5; i++)
            {
                MainCharacter.hp -= 1;
                Console.WriteLine(i + "        Current HP:"  + MainCharacter.hp);
                if (MainCharacter.hp <= 0)
                {
                    Console.Clear();
                    story.WarriorLosses();
                    //Game.ResetGame();
                    Game.Finish();
                    break;
                }
                Thread.Sleep(1000);
            }                      
            Console.Clear();
            Game.Transition<Refugee>();
        }
        internal void Title()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(">>==<<==<<==<<==<<==<<==<<==<<==<<==<<==<<==<<");
            Console.WriteLine("||            Forest of Whispers            ||");
            Console.WriteLine(">>==<<==<<==<<==<<==<<==<<==<<==<<==<<==<<==<<");
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
