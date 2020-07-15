
using System;
using System.Collections.Generic;

namespace LearnLists
{
    class Program
    {
        static void Main()
        {
            List<double> marathons = new List<double>();
            marathons.Add(144.07);
            marathons.Add(143.12);
            Console.WriteLine($"Jemima Sumgong's result is {marathons[0]}");
            Console.WriteLine($"Tiki Gellana's reuslt is {marathons[1]}");

            //Another way to create the List:
            List<double> marathons = new List<double>
            {
            144.07,
             143.12,
             146.73,
             146.33
             };
        }
    }
}
