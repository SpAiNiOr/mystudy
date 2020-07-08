using System;

namespace Spaceman
{
    class Game
    {
        //set filed
        private string codeWord;
        private string currentWord;
        private int maxGuess;
        private int currentWroGuess;
        private string[] words;

        //set properties
        public string CodeWord
        {
            get { return codeWord; }
            set { codeWord = value; }
        }

        public string CurrentWord
        {
            get { return currentWord; }
            set { currentWord = value; }
        }

        public int MaxGuess
        { get; set; }

        public int CurrentWroGuess
        { get; set; }

        public string[] Words
        { get; set; }

        // if we don't privode a constructor, system will provide a default one.

        Random random = new Random();

        public Game()
        {
            MaxGuess = 5;
            CurrentWroGuess = 0;
            int num = random.Next(0, 2);
            Words = new string[] {"kick","ok"};
            CodeWord = Words[num];
            CurrentWord = new String('_', CodeWord.Length);

        }

        //pring allien
        Ufo ufo = new Ufo();

        //method
        public void Greet()
        {
            Console.WriteLine("Save your friend from Aliens!");
        }

        //Check if player won.
        public bool DidWin()
        {
            if (CodeWord.Equals(CurrentWord))
            {
              return true;
            }
            else
            {
              return false;
            }
        }

        //Check if player lose when no more chances.
        public bool DidLose()
        {
            if (CurrentWroGuess >= MaxGuess)
            {
                return true;
            }
            else
            {
              return false;
            }
        }

        //print to the Console.
        public void Display()
        {
            Console.WriteLine(ufo.Stringify());
            Console.WriteLine(CurrentWord);
            int remainingChances = 5 - CurrentWroGuess;
            Console.WriteLine($"You still have {remainingChances} of 5");
        }

        //Get player input
        public void Ask()
        {
            Console.WriteLine("Please input a charactor:");
            string input = Console.ReadLine();
            while (input.Length != 1)
            {
                Console.WriteLine("Please input one charactor at one time! Please input again: ");
                input = Console.ReadLine();
            }

            //missing if we have multi positions have the same char.
            if (codeWord.Contains(input))
            {
                Console.WriteLine("You get one right, please continue guess!");
                int index = codeWord.IndexOf(input);
                CurrentWord = CurrentWord.Remove(index, 1).Insert(index, input);

            }
            else
            {
                CurrentWroGuess += 1;
                ufo.AddPart();
            }
        }
    }
}