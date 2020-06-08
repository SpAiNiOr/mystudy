using System;

namespace BuiltInMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
            int indx = Array.IndexOf(ratings, 3);
            Console.WriteLine(indx);
            Console.WriteLine($"Song number {indx + 1} rated three stars");

            # the second arg is using the Lambda to examine the element is longer than 10 charactors.
            string lng = Array.Find(summerStrut, name => name.Length > 10);
            Console.WriteLine($"The first song that has more than 10 characters in the title is {lng}.¡±");

            Array.Sort(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[summerStrut.Length - 1]);


        }
    }
}