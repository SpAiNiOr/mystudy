using System;

namespace LearnInheritance
{
    class Truck : Vehicle, IAutomobile
    {
        public double Weight
        { get; }

        public Truck(double speed, double weight) : base(speed)
        {
            Weight = weight;

            if (weight < 400)
            {
                Wheels = 8;
            }
            else
            {
                Wheels = 12;
            }
        }

        public override string Describe()
        {
            return "truck";
        }

    }
}