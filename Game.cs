using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Places;
using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using FINAL_PROJECT_GV5.SaveSystem;
using FINAL_PROJECT_GV5.Places;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO.Pipes;

namespace OOP_PROJECT
{
    internal class Game
    {
        List<Place> places = new List<Place>();
        Place currentPlace;
        Place previousPlace;
        internal bool IsGameOver() => isFinished;
        public static bool isFinished;
        static string nextPlace = "";
        public static bool Firstskull = false;

        Characters MainCharacter = new Characters();
        Switch choosechar = new Switch();       
        ContextStory ContextStory = new ContextStory();

        // static SaveSystem saveSystem;
        //public static void SaveGame()
        //{
        //    //Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
        //    const string saveInformation = "saveInformation.txt";
        //    using (FileStream fileStream = File.Create(saveInformation))
        //    {
        //        saveSystem = new SaveSystem(Inventory.Fruits, Inventory.SuperFruits, Inventory.Coins,
        //            Inventory.MegaFruits, Firstskull);

        //        var copy = new BinaryFormatter();
        //        copy.Serialize(fileStream, saveInformation);
        //    }
        //}
        //public static void LoadGame()
        //{
        //    //Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;
        //    const string saveInformation = "saveInformation.txt";
        //    using(FileStream fileStream = File.OpenRead(saveInformation))
        //    {
        //        var copy = new BinaryFormatter();
        //        saveSystem = copy.Deserialize(fileStream) as SaveSystem;
        //        //MainCharacter.Name = saveSystem.name;
        //        //MainCharacter.hp = saveSystem.hp;
        //        //MainCharacter.gold = saveSystem.gold;
        //        //MainCharacter.Weapon = saveSystem.weapon;
        //        //MainCharacter.damage = saveSystem.damage;
        //        Inventory.Fruits = saveSystem.Fruits;
        //        Inventory.Coins = saveSystem.Coins;
        //        Inventory.MegaFruits = saveSystem.MegaFruits;
        //        Inventory.SuperFruits = saveSystem.SuperFruits;
        //        Firstskull = saveSystem.Skull;
        //    }
        //}
        //public static void ResetGame()
        //{
        //    //Characters MainCharacter = Main_Character_Description.Switch.MainCharacter;           
        //    //MainCharacter.Name = "";
        //    //MainCharacter.hp = 0;
        //    //MainCharacter.gold = 0;
        //    //MainCharacter.Weapon = "";
        //    //MainCharacter.damage = 0;
        //    Inventory.Fruits = 0;
        //    Inventory.Coins = 0;
        //    Inventory.MegaFruits = 0;
        //    Inventory.SuperFruits = 0;
        //    Firstskull = false;
        //}
        public void Selection(string choice)
        {
            choosechar.CharacterSelect(choice); 
        }

        internal void Add(Place place)
        {
            places.Add(place);
            if (currentPlace == null)
            {
                currentPlace = place;
            }
        }
        internal string CurrentPlaceDescription => currentPlace.Description();

        internal void MovingAround(string choice2)
        {
            currentPlace.MovingAround(choice2);
            CheckTransition();
        }
        internal static void Transition<T>() where T : Place
        {
            nextPlace = typeof(T).Name;
        }
        public static void Finish()
        {
            isFinished = true;
        }

        public void Back() => nextPlace = previousPlace.GetType().Name;

        internal void CheckTransition()
        {
            foreach (var place in places)
            {
                if (place.GetType().Name == nextPlace)
                {
                    nextPlace = "";
                    currentPlace = place;
                    previousPlace = place;
                    break;
                }
            }
        }       
    }

}

