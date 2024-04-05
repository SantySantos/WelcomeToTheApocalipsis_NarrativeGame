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
            Kairos.hp = 120;
            Kairos.gold = 100;
            Kairos.Weapon = "Axe (10 damage)";

            return Kairos;
        }

        public FemaleCharacters Woman()
        {
            FemaleCharacters Aria = new FemaleCharacters();
            Aria.Name = "Aria";
            Aria.hp = 100;
            Aria.gold = 100;
            Aria.Weapon = "Axe (10 damage)";

            return Aria;
        }


        public void CharacterDescription()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"Please choose your character
[A] See characteristics
[B] select Kairos
[C] Select Aira");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Choose a character");
        }

    }




}

