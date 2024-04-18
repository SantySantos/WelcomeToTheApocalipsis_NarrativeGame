using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP_PROJECT.Main_Character_Description;


namespace OOP_PROJECT.Main_Character_Description
{
    internal class Switch
    {
        public static Characters MainCharacter = new Characters();

        static bool IsChosen;
        internal bool ChoosingChar() => IsChosen;
        internal static void ChooseTrue()
        {
            IsChosen = true;
        }
        public void CharacterSelect(string choice)
        {

            MaleCharacters characterMale = new MaleCharacters();
            FemaleCharacters characterFemale = new FemaleCharacters();


            ChoosingCharacter characterChosen = new ChoosingCharacter();

            switch (choice)
            {
                case "a":
                    characterMale.GeneralMaleDescription();
                    Console.ResetColor();
                    characterFemale.GeneralFemaleDescription();
                    Console.ReadKey();
                    Console.Clear();
                    break;
                case "b":
                    MainCharacter = characterChosen.Man();
                    characterMale.GeneralMaleDescription();
                    Console.ReadKey();
                    Console.Clear();
                    ChooseTrue();
                    break;
                case "c":
                    MainCharacter = characterChosen.Woman();
                    characterFemale.GeneralFemaleDescription();
                    Console.ReadKey();
                    Console.Clear();
                    ChooseTrue();
                    break;
                default:
                    Console.WriteLine("you have chosen an invalid option");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }
    }
    internal class Zarlock
    {
        public string Name { private get; set; } = "Zarlock";
        public int hp { get; set; } = 2000;
        public int damage = 50;
    }
}




