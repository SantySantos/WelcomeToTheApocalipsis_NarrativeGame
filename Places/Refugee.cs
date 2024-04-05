using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Places
{
    internal class Refugee : Place
    {
        internal override string Description()
        {
            Console.WriteLine();
            return @"To the left, a humble [store] offers supplies. 
Straight ahead, the [forest] whispers secrets. 
To the right, the [dungeon] holds riches and horrors.
Only the bravest reach the Crystals of Ages. 
The refuge is a place of respite. Write [1] for stats.



write the place where you want to go";

        }
        internal override void MovingAround(string choice2)
        {
        Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            switch (choice2)
            {
                case "store":
                    Game.Transition<MainStore>();
                    break;
                case "forest":
                    Game.Transition<Forest>();
                    break;
                case "dungeon":
                    Game.Transition<Dungeon>();
                    break;
                case "blacksmith":
                    Game.Transition<BlackSmith>();
                    break;
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(MainCharacter.Name.ToUpper());
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("HP: " + MainCharacter.hp);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("GOLD: " + MainCharacter.gold);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("WEAPON: " + MainCharacter.Weapon);
                    Console.ResetColor();
                    break;
                default:
                    Console.WriteLine("that's not a place, try again");
                    break;
            }
        }
    }


}
