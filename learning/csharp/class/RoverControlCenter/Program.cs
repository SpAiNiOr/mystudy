using System;

namespace RoverControlCenter
{
    class Program
    {
        static void Main(string[] args)
        {
            MoonRover lunokhod = new MoonRover("Lunokhod 1", 1970);
            MoonRover apollo = new MoonRover("Apollo 15", 1971);
            MarsRover sojourner = new MarsRover("Sojourner", 1997);
            Satellite sputnik = new Satellite("Sputnik", 1957);

            Rover[] rovers = { lunokhod, apollo, sojourner };
            DirectAll(rovers);

            //since every object is inherited from Object class, we can create a array by Ojbect type.
            Object[] objects = { lunokhod, apollo, sojourner, sputnik };
            foreach (Object ob in objects)
            {
                Console.WriteLine(ob.GetType());
            }

            //by using the interface, we can use the method in the interface.
            IDirectable[] vehicles = { lunokhod, apollo, sojourner, sputnik };
            DirectAll(vehicles);


        }

        public static void DirectAll(IDirectable[] vehicles)
        {
            foreach (IDirectable vehicle in vehicles)
            {
                Console.WriteLine(vehicle.GetInfo());
                Console.WriteLine(vehicle.Explore());
                Console.WriteLine(vehicle.Collect());
            }
        }

    }
}
