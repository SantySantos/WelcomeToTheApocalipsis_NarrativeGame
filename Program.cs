using OOP_PROJECT;
using OOP_PROJECT.Main_Character_Description;
using OOP_PROJECT.Places;
using OOP_PROJECT.Story;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Serialization;
using System.Threading.Tasks;
using FINAL_PROJECT_GV5.Places;

internal class program
{
    static void Main(string[] args)
    {
        //if (!File.Exists("saveInformation.txt"))
        //{
        //    Game.SaveGame();
        //}
        //Game.LoadGame();

        Characters MainCharacter = OOP_PROJECT.Main_Character_Description.Switch.MainCharacter;

        var game = new Game();
        game.Add(new Refugee());
        game.Add(new MainStore());
        game.Add(new Forest());
        game.Add(new Dungeon());    
        game.Add(new BlackSmith());
        game.Add(new Inventory());

        ContextStory contextStory = new ContextStory();

        Switch choosingCharacters = new Switch();

        var DescriptionChar = new ChoosingCharacter();

        contextStory.Story();

        while (!choosingCharacters.ChoosingChar())
        {
            DescriptionChar.CharacterDescription();
            string choice = Console.ReadLine().ToLower() ?? "";
            game.Selection(choice);
        }

        contextStory.FirstWhisper();

        while (!Game.isFinished)
        {
            Console.WriteLine(game.CurrentPlaceDescription);
            string choice2 = Console.ReadLine().ToLower() ?? "";
            Console.Clear();
            game.MovingAround(choice2);
        }
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Thanks for playing the game, I hope you enjoyed it!!");
        Thread.Sleep(5000);
        Console.ResetColor();
        Console.Clear();
        Console.WriteLine("By Santiago Santos");
    }
}