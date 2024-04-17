using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PROJECT.Story
{
    internal class ContextStory

    {
        public void Story()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("YEAR 3273");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine(@"Since Nova Genesis, the earth has been completely 
consumed by the explosion. There is no life anymore;
the trees are grey, the few survivors are depressed.
Some of them kill themselves, there is no hope.






Until now... ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Press any key To continue...");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadKey();
            Console.Clear();


        }
        public void FirstWhisper()
        {
            Console.ResetColor();
            Console.WriteLine(@"You are the hope. It's your opportunity to change things. 
But for that,Venture into the dungeons and the forest, 
hone your skills, and confront the ultimate challenge. 
Only then can you collect the Crystals of Age and 
restore life to the world. You are the only hope.


Open your eyes... Wake up...");
            Console.WriteLine();
            Console.ReadKey();
            Console.Clear();
        }
        //invadidos por bichos raros,
        //Despredadores, dos especies diferentes
        ///una especia mas pequena que otra
        //la pequena quieren exterina, pero resiste la humanidad
        // llega la especie mas grande del universo.
        // ayudan a la humanidad contra la especia invasora
        // exterminar a los menos poderosos, pero los mas poderosos abusan su poder
        // las calaberas de la especie menos poderosa contiene una gema con la cual el herrero puede crear armas. 

        public void WarriorLosses()
        {
            Console.WriteLine("As the warrior's health dwindles to nothing, a sense of desperation fills the air. ");
            Console.WriteLine("Despite their best efforts, the warrior collapses, exhausted and defeated.");
            Console.WriteLine(" With the warrior's demise, the last hope for humanity fades away. ");
            Console.WriteLine("As time passes, life on Earth diminishes, eventually leading to a world devoid of any signs of life, ");
            Console.WriteLine("symbolizing the ultimate failure to save humanity.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("END");
            Console.ReadKey();
            Console.Clear();
        }
        public void WarriorWins()
        {
            Console.WriteLine("fter a fierce battle, the warrior defeats Zarlock, the enemy boss, securing humanity's future.");
            Console.WriteLine("In the aftermath, the warrior gets the fabled Crystals of Age,");
            Console.WriteLine("with Zarlock vanquished and the Crystals in hand, peace returns, and a new era dawns ");
            Console.WriteLine("thanks to the warrior's courage and skill.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("END");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
