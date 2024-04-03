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
        Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
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
                case "gunsmith":
                    Game.Transition<GunSmith>();
                    break;
                case "1":
                    Console.WriteLine(MainCharacter.Name);
                    //Console.WriteLine(MainCharacter.hp);
                    Console.WriteLine(MainCharacter.gold);
                    break;
                default:
                    Console.WriteLine("that's not a place, try again");
                    break;
            }
        }
    }


}
