using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.Main_Character_Description;
using System.Runtime.InteropServices;
using System.Net.Security;

namespace OOP_PROJECT.Main_Character_Description
{
    internal class ChoosingCharacter
    {

        public MaleCharacters Man()
        {
            MaleCharacters Kairos = new MaleCharacters();
            Kairos.Name = "Kairos";
            Kairos.hp = 500;
            Kairos.gold = 1000;
            Kairos.Weapon = "Sword (200 damage)";
            Kairos.damage = 200;

            return Kairos;
        }

        public FemaleCharacters Woman()
        {
            FemaleCharacters Aria = new FemaleCharacters();
            Aria.Name = "Aria";
            Aria.hp = 200;
            Aria.gold = 500;
            Aria.Weapon = "Arch (100 damage)";
            Aria.damage = 100;

            return Aria;
        }

        public ThirdCharacter Third()
        {
            ThirdCharacter Nova = new ThirdCharacter();
            Nova.Name = "Nova";
            Nova.hp = 40;
            Nova.gold = 100;
            Nova.Weapon = "Axe (20 damage)";
            Nova.damage = 20; 

            return Nova;
        }
        public void CharacterDescription()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"Please choose your character
[A] See characteristics
[B] select Kairos
[C] Select Aira
[D] Select Nova");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Choose a character");
        }

    }




}

