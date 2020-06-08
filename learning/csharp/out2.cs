using System;

namespace UsingOut
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Whisper("HeLLO", out bool flg));
            Console.WriteLine(flg);

        }
        static string Whisper(string name, out bool flag)
        {
            flag = true;
            return name.ToLower();

        }
    }
}