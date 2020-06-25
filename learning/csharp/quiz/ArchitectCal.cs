using System;

namespace ArchitectArithmetic
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Rect(4, 5));
            Console.WriteLine(Circle(4));
            Console.WriteLine(Triangle(10, 9));

            double area = Rect(1500, 2500) + Circle(375) + Triangle(750, 500);
            double cost = area * 180;

            Console.WriteLine($"The total area is {area}");

            cost = Math.Round(cost, 2);
            Console.WriteLine($"The total cost is {cost}");

            double newCost = CalculateTotalCost(1500, 2500, 375, 750, 500);
            Console.WriteLine($"The total cost is {newCost}");


        }

        public static double CalculateTotalCost(double x, double y, double radius, double bottom, double height)
        {
            double area = Rect(x, y) + Circle(radius) + Triangle(bottom, height);
            double cost = area * 180;
            cost = Math.Round(cost, 2);
            return cost;

        }

        public static double Rect(double x, double y)
        {
            double area = x * y;
            return area;
        }

        public static double Circle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        public static double Triangle(double bottom, double height)
        {
            double area = 0.5 * bottom * height;
            return area;
        }
    }
}
