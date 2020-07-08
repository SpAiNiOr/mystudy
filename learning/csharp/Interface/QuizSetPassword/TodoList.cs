using System;

namespace SavingInterface
{
    class TodoList : IDisplayable
    {
        public string[] Todos
        { get; private set; }

        //we don't need access control, so it doen't have the properties.
        private int nextOpenIndex;

        public char HeaderSymbol { get; }


        public TodoList()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
            //initial the properties that inherited from interface.
            HeaderSymbol = '-';
        }

        //check if todo is more than 5. If yes, didn't add any more.
        public void Add(string todo)
        {
            if (nextOpenIndex <= 4)
            {
                Todos[nextOpenIndex] = todo;
                nextOpenIndex++;
            }
        }

        //implement the interface method Display()
        public void Display()
        {
            string line = new String(HeaderSymbol, 5);
            Console.WriteLine("Todos");
            Console.WriteLine(line);
            foreach (string todo in Todos)
            {
                if (String.IsNullOrEmpty(todo))
                {
                    Console.WriteLine("[]");
                }
                else
                {
                    Console.WriteLine(todo);
                }
            }
        }

        //implement the interface method Reset()
        public void Reset()
        {
            Todos = new string[5];
            nextOpenIndex = 0;
        }
    }
}