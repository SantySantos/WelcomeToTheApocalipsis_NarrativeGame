using FINAL_PROJECT_GV5.Places;
using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows;
using System.Xml.Schema;

namespace OOP_PROJECT.Places
{
    internal class Dungeon : Place
    {
        public static Zarlock zarlock = new Zarlock();
        internal override string Description()
        {
      
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Final Chamber: Last Stand for Earth ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine();
            Context();
            Instructions();
            Console.WriteLine();
            return @"Press any key to start the fight";
        }
        internal override void MovingAround(string choice2)
        {
            switch(choice2)
            {
                default:
                    Fight();
                    break;
            }
        }
        internal void Context()
        {
            Console.WriteLine("Deep within the dungeon, the Final Chamber awaits. It's a small, eerie space,");
            Console.WriteLine("lit only by a few flickering torches.");
            Console.WriteLine();
            Console.WriteLine("In this shadowed arena, the warrior confronts the final boss,");
            Console.WriteLine("nowing that the outcome of this battle will determine the fate of Earth itself.");
            Console.WriteLine("Both are poised for the ultimate battle, knowing that only one will emerge");
            Console.WriteLine("victorious from this intense and decisive encounter.");
            Console.ReadKey();
            Console.Clear();
        }
        internal void Instructions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Final Chamber: Last Stand for Earth ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("INSTRUCTIONS");
            Console.ResetColor();
            // name : Zarlock
            Console.WriteLine("1. Welcome to the showdown! You'll take a turn, then it's Zarlock's move.");
            Console.WriteLine("2. During your turn, you can choose to heal or attack.");
            Console.WriteLine("3. Zarlock can only attack, but he can deal critical damage.");
            Console.WriteLine("4. You will have to go through the forest");

        }
    
       
        static void Fight()
        {
           
            var story = new ContextStory();
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            Zarlock zarlock = OOP_PROJECT.Places.Dungeon.zarlock;
            Forest forest = new Forest();
            forest.PrintingWaitingTime();
            while (MainCharacter.hp > 0 && zarlock.hp >0) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("The Final Chamber: Last Stand for Earth ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
                Console.ResetColor();
                Console.WriteLine("press [1] to attack or [2] to heal");
                string answer = Console.ReadLine().ToLower() ?? "";
                switch(answer)
                {

                    case "1":
                        PlayerAttacks();
                        Thread.Sleep(1000);
                        ZarlocksDamage(); //Zarlock's attack
                        
                        break;
                    case "2":
                        PlayerHeals();
                        break;
                    default: 
                        Console.WriteLine("Choose a valid option");
                        break;

                }
            }
            if (MainCharacter.hp <= 0)
            {
                Console.Clear();
                story.WarriorLosses();
                //Game.ResetGame();
                Game.Finish();
                
            }
            else if(zarlock.hp <= 0)
            {
                Console.Clear();
                story.WarriorWins();
                //Game.ResetGame();
                Game.Finish();
            }            
        }
        static double PlayerAttacks()
        {
            Zarlock zarlock = OOP_PROJECT.Places.Dungeon.zarlock; 
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
           
            zarlock.hp -= mainCharacter.damage;
            Console.WriteLine(zarlock.hp);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YOU HAVE ATTACKED");
            Console.ResetColor();
            Console.WriteLine("You did " + mainCharacter.damage + " damage");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Currrent HP: " + mainCharacter.hp);
            Console.WriteLine();
            Console.ResetColor();
            return zarlock.hp; 
        }
        static double ZarlocksDamage()
        {
            int[] damage = new int[] { 0, 50, 80, 120 };
            Random attack = new Random();
            int damageChosen = attack.Next(0, damage.Length);
            int damageReleased = damage[damageChosen];
            Zarlock zarlock = OOP_PROJECT.Places.Dungeon.zarlock;
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
            mainCharacter.hp -= damageReleased;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ZARLOCK HAS ATTACKED");
            Console.ResetColor();
            Console.WriteLine("Zarclock did " + damageReleased + " damage");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Currrent HP: " + mainCharacter.hp);
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Zarlock's hp: " + zarlock.hp);
            Console.ResetColor();
            Console.ReadKey();
            Console.Clear();           
            return mainCharacter.hp;

        }

       static void PlayerHeals()
        {
            while (true)
            {
                var inventory = new Inventory();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FIGHT INVENTORY");
                Console.ResetColor();
                Console.WriteLine("1. Fruits: " + inventory.ShowingFruits());
                Console.WriteLine("2. Super Fruits: " + inventory.ShowingSuperFruits());
                Console.WriteLine("3. Mega Fruits: " + inventory.ShowingMegaFruits());
                Console.WriteLine();
                Console.WriteLine("What would u like to use? ");
                string reply = Console.ReadLine().ToLower() ?? "";
                while (true)
                {
                    if (reply == "1")
                    {
                        if(inventory.ShowingFruits() > 0)
                        {
                            inventory.UsingFruits();                           
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You healed: +5 HP");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have more Fruits!");
                            break;
                            
                        }
                    }
                    else if (reply == "2")
                    {
                        if(inventory.ShowingSuperFruits() > 0)
                        {

                        inventory.UsingSuperFruits();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("You healed: +38 HP");
                        Console.ResetColor();
                        break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have more SuperFruits!");
                            break;
                        }
                    }
                    else if(reply == "3")
                    {
                        if (inventory.ShowingMegaFruits() > 0)
                        {

                            inventory.UsingMegaFruits();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("You healed: +100 HP");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You dont have more SuperFruits!");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Choose a valid option (1 or 2) next time :) ");
                        break;
                    }

                }
                Thread.Sleep(1000);
                ZarlocksDamage();
                
                break;
            }
            
        }
    }
}


