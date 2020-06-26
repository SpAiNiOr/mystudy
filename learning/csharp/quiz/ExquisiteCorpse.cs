using System;

namespace ExquisiteCorpse
{
    class Program
    {
        static void Main(string[] args)
        {
            // This is how we can print image to the console. by using the swith, we can handle each part individuly. And since the process is so quick, the user can't see we actually print the image line by line.
            MonsterHead();
            GhostBody();
            BugFeet();

            //Since we are using the number version of the build creature method. this one is commentted. 
            //BuildACreature("ghost", "bug", "monster");

            // by using convert the string to int, we can use the new switch method to get the creature printed. This is called code refactored.
            int headNum = TranslateToNumber("ghost");
            int bodyNum = TranslateToNumber("bug");
            int feetNumb = TranslateToNumber("monster");
            RandomBuildACreature(headNum, bodyNum, feetNumb);


            Console.WriteLine("The following is automatically generated!");
            RandomMode();


        }
        //This is using swtich for each part.
        /*
        public static void BuildACreature(string head, string body, string feet)
        {
          switch(head)
          {
            case "bug":
            BugHead();
            break;

            case "ghost":
            GhostHead();
            break;

            case "moster":
            MonsterHead();
            break;

            default:
            break;
          }

          switch(body)
          {
            case "bug":
            BugBody();
            break;

            case "ghost":
            GhostBody();
            break;

            case "moster":
            MonsterBody();
            break;

            default:
            break;
          }

          switch(feet)
          {
            case "bug":
            BugFeet();
            break;

            case "ghost":
            GhostFeet();
            break;

            case "moster":
            MonsterFeet();
            break;

            default:
            break;
          }
        }
        */

        // we generate 3 random number for each part. And using the new swich to reflect the type by number instead of the name.
        public static void RandomMode()
        {
            Random randomNumber = new Random();
            int head = randomNumber.Next(1, 4);
            int body = randomNumber.Next(1, 4);
            int feet = randomNumber.Next(1, 4);
            RandomBuildACreature(head, body, feet);
        }

        public static void RandomBuildACreature(int head, int body, int feet)
        {
            switch (head)
            {
                case 1:
                    BugHead();
                    break;

                case 2:
                    GhostHead();
                    break;

                case 3:
                    MonsterHead();
                    break;

                default:
                    break;
            }

            switch (body)
            {
                case 1:
                    BugBody();
                    break;

                case 2:
                    GhostBody();
                    break;

                case 3:
                    MonsterBody();
                    break;

                default:
                    break;
            }

            switch (feet)
            {
                case 1:
                    BugFeet();
                    break;

                case 2:
                    GhostFeet();
                    break;

                case 3:
                    MonsterFeet();
                    break;

                default:
                    break;
            }
        }

        public static int TranslateToNumber(string creature)
        {
            int num;

            switch (creature)
            {
                case "ghost":
                    num = 1;
                    break;

                case "bug":
                    num = 2;
                    break;

                case "monster":
                    num = 3;
                    break;

                default:
                    num = 0;
                    break;
            }

            return num;
        }

        static void GhostHead()
        {
            Console.WriteLine("     ..-..");
            Console.WriteLine("    ( o o )");
            Console.WriteLine("    |  O  |");
        }

        static void GhostBody()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
        }

        static void GhostFeet()
        {
            Console.WriteLine("    |     |");
            Console.WriteLine("    |     |");
            Console.WriteLine("    '~~~~~'");
        }

        static void BugHead()
        {
            Console.WriteLine("     /   \\");
            Console.WriteLine("     \\. ./");
            Console.WriteLine("    (o + o)");
        }

        static void BugBody()
        {
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
            Console.WriteLine("  --|  |  |--");
        }

        static void BugFeet()
        {
            Console.WriteLine("     v   v");
            Console.WriteLine("     *****");
        }

        static void MonsterHead()
        {
            Console.WriteLine("     _____");
            Console.WriteLine(" .-,;='';_),-.");
            Console.WriteLine("  \\_\\(),()/_/");
            Console.WriteLine("¡¡  (,___,)");
        }

        static void MonsterBody()
        {
            Console.WriteLine("   ,-/`~`\\-,___");
            Console.WriteLine("  / /).:.('--._)");
            Console.WriteLine(" {_[ (_,_)");
        }

        static void MonsterFeet()
        {
            Console.WriteLine("    |  Y  |");
            Console.WriteLine("   /   |   \\");
            Console.WriteLine("   \"\"\"\" \"\"\"\"");
        }
    }
}
