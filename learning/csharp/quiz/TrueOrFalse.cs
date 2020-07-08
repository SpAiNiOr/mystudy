using System;

namespace TrueOrFalse
{
    class Program
    {
        static bool TryParse(string value, out bool result)
        {
            if (value == "true" || value == "false")
            {
                result = true;
                return true;
            }
            else
            {
                result = false;
                return false;
            }
        }
        static void Main(string[] args)
        {
            // Do not edit these lines
            Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
            string entry = Console.ReadLine();
            Tools.SetUpInputStream(entry);

            // Type your code below
            string[] questions = new string[] { "10 is 10?", "today is 5/11" };
            bool[] answers = new bool[] { true, false };
            bool[] responses = new bool[questions.Length];

            if (questions.Length != answers.Length)
            {
                Console.WriteLine("You need check the Q&A");
            }

            //get answers and check the if the input is 'true' or 'false'
            int askingIndex = 0;
            foreach (string q in questions)
            {
                string input;
                bool isBool;
                bool inputBool;
                Console.WriteLine(q);
                Console.Write("True or False?");
                input = Console.ReadLine();
                isBool = TryParse(input, out inputBool);
                // check the input, if not the bool string, ask to input again.
                while (isBool == false)
                {
                    Console.WriteLine("Please respond with 'true' or 'false'.");
                    input = Console.ReadLine();
                    isBool = Boolean.TryParse(input, out inputBool);
                }
                responses[askingIndex] = inputBool;
                askingIndex = +1;

            }

            // print out answers
            foreach (bool res in responses)
            {
                Console.WriteLine(res);
            }

            //calculate the score
            int scoringIndex = 0;
            int score = 0;

            foreach (bool ans in answers)
            {
                Console.WriteLine($"Input: {responses[scoringIndex]} | Anwser: {ans}");
                if (responses[scoringIndex] == ans)
                {
                    score = +1;
                }
                scoringIndex = +1;
            }

            //Print out the Score.
            Console.WriteLine($"You got the {score} of 2 correct");
        }
    }
}
