using OOP_PROJECT.Main_Character_Description;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text;
namespace OOP_PROJECT.Places
{
    enum Weapons
    {
        RustedMachete = 1,
        PlasmaRepeater = 100,
        ElectroKatana = 200,    
        EPRK = 400,
        InterstellarHypernovaCosmicDevastatorOfUniversalDestruction = 100000
    }
    internal class BlackSmith : Place
    {
        internal override string Description()
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            
            Title();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gold remaining:" + MainCharacter.gold);
            Console.ResetColor();
            Console.WriteLine();
            return @"Ah, welcome, welcome! What brings you to my forge today?
In need of a repair, or perhaps something new? Whatever it is, you've come to the right place.
Come, let's have a look and see what we can do for you

1. Rusted- Machete (1 damage) - 5 gold
2. Plasma-Repeater (100 damage) - 1500 gold
3. Electro-Katana (200 damage) - 3000 gold
4. EPRK (400 damage) - 1 skulls 
5. Interstellar-Hypernova-Cosmic-Devastator-of-Universal-Destruction (100000 damage) - 100000
6. Back to Refugee";
        }

        internal void SuccessfulPurchase()
        {
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;

            Title();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Gold remaining:" + MainCharacter.gold);
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Ah, welcome, welcome! What brings you to my forge today?");
            Console.WriteLine("In need of a repair, or perhaps something new? Whatever it is, you've come to the right place.");
            Console.WriteLine("Come, let's have a look and see what we can do for you");
            Console.WriteLine();
            Console.WriteLine("1. Rusted- Machete (1 damage) - 5 gold");
            Console.WriteLine("2. Plasma-Repeater (100 damage) - 1500 gold");
            Console.WriteLine("3. Electro-Katana (200 damage) - 3000 gold");
            Console.WriteLine("4. EPRK (400 damage) - 1 skulls ");
            Console.WriteLine("5. Interstellar-Hypernova-Cosmic-Devastator-of-Universal-Destruction (100000 damage) - 100000");
            Console.WriteLine("6. Back to Refugee");
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
                SuccessfulPurchase();
                
                return true;
            }
            else
            {
                Console.WriteLine("Insuficient Gold");
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
                       
                        MainCharacter.damage = (int)Weapons.RustedMachete;
                        //Game.SaveGame();
                    }
                    else if (GoldReturn(5) == false) { Console.WriteLine("You dont have enough gold");
                        MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "2":
                    if (GoldReturn(1500) == true)
                    {                       
                        MainCharacter.Weapon = Weapons.PlasmaRepeater.ToString();
                        MainCharacter.damage = (int)Weapons.PlasmaRepeater;
                        //Game.SaveGame();
                    }
                    else if(GoldReturn(1500) == false) { Console.WriteLine("You dont have enough gold");
                        MainCharacter.Weapon = MainCharacter.Weapon; }
                    break;
                case "3":
                    if (GoldReturn(3000) == true)
                    {                       
                        MainCharacter.Weapon = Weapons.ElectroKatana.ToString();
                        MainCharacter.damage = (int)Weapons.ElectroKatana;
                        //Game.SaveGame();
                    }
                    else if (GoldReturn(3000) == false) { Console.WriteLine("You dont have enough gold");
                        MainCharacter.Weapon = MainCharacter.Weapon;
                        goto case "6";
                    }
                    break;
                case "4":
                    if(Game.Firstskull == true)
                    {

                        MainCharacter.Weapon = Weapons.EPRK.ToString();
                        MainCharacter.damage = (int)Weapons.EPRK;
                        SuccessfulPurchase();
                        //Game.SaveGame();

                    }
                    else
                    {
                        Console.WriteLine("Are you sure you have two skulls?");
                        MainCharacter.Weapon = MainCharacter.Weapon;
                        goto case "6";
                    }
                    break;
                case "5":
                    if (GoldReturn(100000) == true)
                    {
                        MainCharacter.Weapon = Weapons.InterstellarHypernovaCosmicDevastatorOfUniversalDestruction.ToString();
                        MainCharacter.damage = (int)Weapons.InterstellarHypernovaCosmicDevastatorOfUniversalDestruction;
                        //Game.SaveGame();
                    }
                    else if (GoldReturn(3000) == false) { Console.WriteLine("You dont have enough gold");

                        MainCharacter.Weapon = MainCharacter.Weapon;
                        goto case "6";
                    }                    
                    break;
                case "6":
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
            Console.ForegroundColor = ConsoleColor.DarkGray;
            
            Console.WriteLine("╔═══════════════════════╗   ");
            Console.WriteLine("║    The Blacksmith     ║   ");
            Console.WriteLine("╚═══════════════════════╝   ");
            Console.WriteLine();
            
            Console.ResetColor();
        }

    }
    
}

