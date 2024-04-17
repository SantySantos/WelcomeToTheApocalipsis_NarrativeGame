using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Places;
using OOP_PROJECT.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace OOP_PROJECT
{

    internal class Game
    {
        List<Place> places = new List<Place>();
        Place currentPlace;
        internal bool IsGameOver() => isFinished;
        public static bool isFinished;
        static string nextPlace = "";
        public static bool Firstskull;



        Characters MainCharacter = new Characters();
        Switch choosechar = new Switch();       
        ContextStory ContextStory = new ContextStory();

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

        internal void CheckTransition()
        {
            foreach (var place in places)
            {
                if (place.GetType().Name == nextPlace)
                {
                    nextPlace = "";
                    currentPlace = place;
                    break;
                }
            }
        }       
    }

}

