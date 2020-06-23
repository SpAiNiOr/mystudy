using System;

namespace MoneyMaker
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Money Maker!");
            Console.WriteLine("Enter an amount to convert to coins:");
            string nm = Console.ReadLine();
            double money = Convert.ToDouble(nm);
            Console.WriteLine($"{money} cents is equal to...");
            int gold = 10;
            int silver = 5;

            double goldCoins = Math.Floor(money / gold);
            double remainder = money % gold;

            double silverCoins = Math.Floor(remainder / silver);
            remainder = remainder % 5;

            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze coins: {remainder}");
        }
    }
}
