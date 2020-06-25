using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program sample program...
            Author: Ice...
            */


            // Let the user know that the program is starting:
            Console.WriteLine("The program is running...");

            // Give the Mad Lib a title:
            string title = "Tst";

            Console.WriteLine(title);
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();

            Console.WriteLine("Enter a feeling");
            string feeling = Console.ReadLine();

            Console.WriteLine("Enter a texture");
            string texture = Console.ReadLine();

            Console.Write("Choose a verb: sit, eat, sleep");
            string verb = Console.ReadLine();

            Console.Write("Choose 2 noun: cabin, toaster");
            string gname = Console.ReadLine();
            Console.Write("Please input the second one");
            string item = Console.ReadLine();
            // The template for the story:


            string story = "This morning _ woke up feeling _. 'It is going to be a _ day!' Outside, a bunch of _s were protesting to keep _ in stores. They began to _ to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";


            // Print the story:
            Console.WriteLine("The original one is: " + story);

            string newStory = $"This morning {name} woke up feeling {color}. 'It is going to be a {feeling} day!' Outside, a bunch of {texture}s were protesting to keep {verb} in stores. They began to {gname} to the rhythm of the _, which made all the _s very _. Concerned, _ texted _, who flew _ to _ and dropped _ in a puddle of frozen _. _ woke up in the year _, in a world where _s ruled the world.";

            Console.WriteLine(newStory);


        }
    }
}
