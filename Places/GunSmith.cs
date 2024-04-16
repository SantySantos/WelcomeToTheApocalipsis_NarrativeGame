using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Places
{
    enum Weapons
    {
        RustedMachete = 5,
        PlasmaRepeater = 150,
        ElectroKatana = 400,    
        EPRK = 800,
        InterstellarHypernovaCosmicDevastatorOfUniversalDestruction = 100000
    }
    internal class BlackSmith : Place
    {

        internal override string Description()
        {
            return @"Ah, welcome, welcome! What brings you to my forge today?
In need of a repair, or perhaps something new? Whatever it is, you've come to the right place.
Come, let's have a look and see what we can do for you

1.Rusted machete - 5 gold
2.Plasma Repeater - 1500 gold
3.Electro-Katana - 3000 gold
4.EPRK - 2 skulls 
5. Interstellar Hypernova Cosmic Devastator of Universal Destruction - 100000
6.Back to Refugee";
        }
        public bool GoldReturn(int price)
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;

            if (MainCharacter.gold - price >= 0)
            {
                MainCharacter.gold -= price;
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.WriteLine("Gold remaining:" + MainCharacter.gold);
                Console.ResetColor();
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Insuficient Gold");
                return false;
            }
        }
        public bool HaveSkulls(bool OneSkull, bool TwoSkull)
        {
            if (OneSkull == true && TwoSkull == true)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Are you sure you have the two skulls? ");
                return false;
            }
        }
        internal override void MovingAround(string choice2)
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            var game = new Game();
            switch (choice2)
            {
                case "1":
                    
                    if (GoldReturn(5) == true)
                    {
                        
                        MainCharacter.Weapon = Weapons.RustedMachete.ToString();
                    }
                    else if (GoldReturn(5) == false) { MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "2":
                    if (GoldReturn(1500) == true)
                    {
                        GoldReturn(1500);
                        MainCharacter.Weapon = Weapons.PlasmaRepeater.ToString();
                    }
                    else if(GoldReturn(1500) == false) { MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "3":
                    if (GoldReturn(3000) == true)
                    {
                        GoldReturn(3000);
                        MainCharacter.Weapon = Weapons.ElectroKatana.ToString();
                    }
                    else if (GoldReturn(3000) == false) { MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "4":
                   
                    break;
                case "5":
                    if (GoldReturn(100000) == true)
                    {
                        GoldReturn(100000);
                        MainCharacter.Weapon = Weapons.InterstellarHypernovaCosmicDevastatorOfUniversalDestruction.ToString();
                    }
                    else if (GoldReturn(3000) == false) { MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "6":
                    Game.Transition<Refugee>();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
        }
        public virtual double Axe()
        {
            return 10;
        }

    }
    
}

