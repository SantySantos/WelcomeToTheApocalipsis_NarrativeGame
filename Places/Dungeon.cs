using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
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
        internal override string Description()
        {
            int counter = 0;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The Final Chamber: Last Stand for Earth ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.ResetColor();
            Console.WriteLine();
            if (counter == 0)
            {
                counter++;
                Context();
                Instructions();
            }
            counter++;
            return @"Press [1] to attack or [2] to heal";
        }
        internal override void MovingAround(string choice2)
        {
            switch(choice2)
            {
                case "1":
                    PlayerAttacks();
                    ZarlocksDamage();
                    IfDead();                 
                    break;
                case "2":
                    
                    ZarlocksDamage();
                    IfDead();
                    break;
            }
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
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Press any key to continue");
            Console.ResetColor();

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
        internal void ZarlocksDamage()
        {
            Zarlock Zarlock = new Zarlock();
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
            mainCharacter.hp -= Zarlock.damage;
        }
        internal void IfDead()
        {
            var story = new ContextStory();
            Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
            Zarlock zarlock = new Zarlock();
            if (MainCharacter.hp <= 0)
            {
                Console.Clear();
                story.WarriorLosses();
                Game.Finish();
            }
            else if(zarlock.hp <= 0)
            {
                Console.Clear();
                story.WarriorWins();
                Game.Finish();
            }
            
        }
        internal double PlayerAttacks()
        {
            Zarlock zarlock = new Zarlock();
            BlackSmith weapon = new BlackSmith();
            Characters mainCharacter = Main_Character_Description.Switch.MainCharacter;
            zarlock.hp -= weapon.WeaponDamage;
            return zarlock.hp;
        }
       
    }
}

public class Zarlock
{
    public string Name = "Zarlock";
    public int hp = 2000;
    public int damage = 50;
}
