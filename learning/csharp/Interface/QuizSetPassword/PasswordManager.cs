using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable
    {
        private string password;
        private string Password
        {
            get { return password; }
            set
            {
                if (value.Length < 8) { password = "abcdefg"; }
                else { password = value; }
            }
        }

        public bool Hidden
        { get; private set; }

        public char HeaderSymbol
        { get; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            HeaderSymbol = '-';
        }

        //implement the interface method Display()
        public void Display()
        {
            string line = new String(HeaderSymbol, 5);
            Console.WriteLine("Password");
            Console.WriteLine(line);
            if (Hidden == true)
            {
                Console.WriteLine("****");
            }
            else
            {
                Console.WriteLine(Password);
            }
        }

        //implement the interface method Reset()
        public void Reset()
        {
            Password = String.Empty;
            Hidden = false;
        }

        public bool ChangePassword(string oldPassword, string newPassword)
        {
            if (Password == oldPassword)
            {
                Password = newPassword;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}