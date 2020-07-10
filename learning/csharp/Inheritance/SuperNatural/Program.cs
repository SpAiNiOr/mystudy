using System;

namespace MagicalInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Storm storm = new Storm("wind", false, "Zul 'rajas");
            Console.WriteLine(storm.Announce());

            Pupil pupil = new Pupil("Ice");
            //CastWindStorm method generate a new Storm object, therefor we can use the Storm method.
            Console.WriteLine(pupil.CastWindStorm().Announce());

            Mage mage = new Mage("Cookie");
            Console.WriteLine(mage.CastRainStorm().Announce());

            Archmage archmage = new Archmage("God");
            Console.WriteLine(archmage.CastRainStorm().Announce());
            Console.WriteLine(archmage.CastRainStorm().Announce());

            Storm[] storms = new Storm[3];
            Pupil p = new Pupil("Mezil-kree", "Icecrown");
            Mage m = new Mage("Gul'dan", "Draenor");
            Archmage a = new Archmage("Nielas Aran", "Stormwind");

            //because the array element type is Storm. We can't directly use it.
            storms[0] = p.CastWindStorm();
            storms[1] = m.CastRainStorm();
            storms[2] = a.CastLightningStorm();

            foreach (Storm sto in storms)
            {
                Console.WriteLine(p.Origin);
                Console.Write(sto.Announce());
            }
        }
    }
}