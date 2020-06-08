using System;

namespace DocumentationHunt
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] summerStrut;

            summerStrut = new string[] { "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles" };

            int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };

            string[] summerStrutCopy = new string[summerStrut.Length];
            Array.Copy(summerStrut, summerStrutCopy, summerStrutCopy.Length);
            Console.WriteLine(summerStrut[0]);

            Array.Reverse(summerStrut);
            Console.WriteLine(summerStrut[0]);
            Console.WriteLine(summerStrut[summerStrut.Length - 1]);
            Array.Clear(ratings, 0, (ratings.Length - 1));
            Console.WriteLine(ratings[0]);
        }
    }
}
