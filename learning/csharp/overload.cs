using System;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            NamePets("a", "b");
            NamePets("1", "2", "3");
            NamePets();

        }

        static void NamePets(string name1, string name2)
        {
            Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
        }
        static void NamePets(string name1, string name2, string name3)
        {
            Console.WriteLine($"Your pets {name1}, {name2}, and {name3} will be joining your voyage across space!");
        }

        static void NamePets()
        {
            Console.WriteLine("Aw, you have no spacefaring pets :(");
        }

    }
}