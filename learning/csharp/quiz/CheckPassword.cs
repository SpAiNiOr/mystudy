using System;

namespace PasswordChecker
{
    class Program
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "abcdefghijklmnopqrstwyz";
            string lowercase = "ABCDEFGHIJKLMNOPQRSTWYZ";
            string digits = "1234567890";
            string specialChars = "`~!@#$%^&*()-=_+[]\\{}|;':,.<>";

            Console.WriteLine("Please input a password");
            string pas = Console.ReadLine();

            int score = 0;
            if (pas.Length >= minLength)
            {
                score += 1;
            }

            if (Tools.Contains(pas, uppercase))
            {
                score += 1;
            }
            if (Tools.Contains(pas, digits))
            {
                score += 1;
            }
            if (Tools.Contains(pas, specialChars))
            {
                score += 1;
            }

            if (pas == "password" || pas == "1234")
            {
                score = 0;
            }

            Console.WriteLine("Your password score is " + score);
            switch (score)
            {
                case 1:
                    Console.WriteLine("Weak Password");
                    break;

                case 2:
                    Console.WriteLine("Medium Password");
                    break;

                case 3:
                    Console.WriteLine("Strong Password");
                    break;

                case 4:
                    Console.WriteLine("Extremely Strong Password");
                    break;

                case 5:
                    Console.WriteLine("Extremely Strong Password");
                    break;

                default:
                    Console.WriteLine(" ");
                    break;

            }
        }
    }
}
