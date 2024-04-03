using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Places
{
    internal class Forest : Place
    {
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
            Console.WriteLine(@"In the forest, you will need to 
collect gold to be able to buy things in the store, while you are there, you will be receiving
constant damage, these are the rules:

1. You will need to pay 20 gold to join the forest
2. It wil take you 10 seconds without being able to do anything to leave the forest
3. You might receive random hits wich damage 20HP 
4. If you die, game is over.

HAVE FUN

press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            Console.ResetColor();
        }

    }
}
