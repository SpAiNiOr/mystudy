using System;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Sedan bmw = new Sedan(60);
            Sedan benz = new Sedan(70);
            Truck tesla = new Truck(45, 500);

            Console.WriteLine(bmw.Speed);
            Console.WriteLine(bmw.Wheels);
            Console.WriteLine(bmw.LicensePlate);

            Console.WriteLine(benz.Speed);
            Console.WriteLine(benz.Wheels);
            Console.WriteLine(benz.LicensePlate);

            Console.WriteLine(tesla.Speed);
            Console.WriteLine(tesla.Wheels);
            Console.WriteLine(tesla.LicensePlate);

            bmw.SpeedUp();
            benz.SpeedUp();
            tesla.SpeedUp();

            Console.WriteLine(bmw.Speed);
            Console.WriteLine(benz.Speed);
            Console.WriteLine(tesla.Speed);

        }
    }
}