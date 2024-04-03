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
            return @"To the left, a modest [store] offers essential supplies and equipment 
to aid the player on their journey. The storekeeper, a grizzled old survivor, nods in
greeting, ready to assist the player with their needs.

                
Straight ahead lies the entrance to the [forest], a once lush and vibrant expanse now shrouded in mystery and danger. 
The trees whisper ancient secrets, beckoning the player to explore their depths and uncover hidden treasures.

                
To the right, the entrance to the [dungeon] looms ominously. Dark and foreboding, it is said to hold untold riches 
and unimaginable horrors. But to reach the dungeon, the player must first brave the perils of the forest, where danger 
lurks behind every tree. Deep within the dungeon, guarded by a fearsome monster, are the Crystals of Ages. These legendary artifacts are said to hold
the power to restore life to the world. Only the bravest and most skilled adventurers dare to face the monster and claim the crystals.



The refuge is a place of respite and preparation

Write [1] to see your actual stats



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
