using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Places
{
    internal class BlackSmith : Place
    {

        internal override string Description()
        {
            return @"Ah, welcome, welcome! What brings you to my forge today?
In need of a repair, or perhaps something new? Whatever it is, you've come to the right place.
Come, let's have a look and see what we can do for you

1.Rusted machete - 5 gold
2.Shockwave Grenade - 50 gold
3.Plasma Repeater - 500 gold
4.Electro-Katana - 1500 gold
5.EPRK - 2 skulls 
6.Back to Refugee";
        }
        public string GoldReturn(int price)
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;

            if (MainCharacter.gold - price >= 0)
            {
                MainCharacter.gold -= price;
                return "you have " + MainCharacter.gold.ToString() + "left";
            }
            else
            {
                return "You dont have enough Money";
            }
        }
        public bool HaveSkulls(bool OneSkull, bool TwoSkull)
        {
            if(OneSkull == true && TwoSkull == true) 
            {
                return true;
            }
            else 
            { 
                return false;
            }
        }
        internal override void MovingAround(string choice2)
        {
            var game = new Game();
            switch (choice2)
            {
                case "1":
                    GoldReturn(5);
                    break;
                case "2":
                    GoldReturn(50);
                    break;
                case "3":
                    GoldReturn(500);
                    break;
                    case "4":
                    GoldReturn(1500);
                    break;
                    case "5":
                    HaveSkulls(game.Firstskull, game.SecondSkull);
                    break; 
                case "6":
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
    }
}
