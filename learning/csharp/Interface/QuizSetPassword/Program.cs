using System;

namespace SavingInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            TodoList tdl = new TodoList();
            tdl.Add("Invite friends");
            tdl.Add("Buy decorations");
            tdl.Add("Party");
            //use the Display() method
            tdl.Display();

            //use the Reset() method
            tdl.Reset();
            tdl.Display();

            PasswordManager pm = new PasswordManager("iluvpie", true);
            //use the Display() method
            pm.Display();
            //use the Reset() method
            pm.Reset();
            pm.Display();
        }
    }
}
