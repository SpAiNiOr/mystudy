using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Please input your word:");
            string oldMsg = Console.ReadLine();
            //Convert the upper to lower
            oldMsg = oldMsg.ToLower();
            char[] seceretMessage = oldMsg.ToCharArray();
            char[] encryptedMessageArray = new char[seceretMessage.Length];
            Char[] decryptedMessageArray = new char[seceretMessage.Length];

            //encode
            for (int i = 0; i < seceretMessage.Length; i++)
            {
                char temp = seceretMessage[i];
                // We need to use the char to get the Index of alphebat
                int position = Array.IndexOf(alphabet, temp);
                //Please notice it's +=
                position += 3;
                //wrap around
                position = position % 26;
                char newChar = alphabet[position];
                encryptedMessageArray[i] = newChar;

            }

            string newMsg = String.Join("", encryptedMessageArray);
            Console.WriteLine($"The new word is {newMsg}");


            // decode
            for (int i = 0; i < seceretMessage.Length; i++)
            {
                char temp = encryptedMessageArray[i];
                // We need to use the char to get the Index of alphebat
                int position = Array.IndexOf(alphabet, temp);
                //Please notice it's +=
                position += -3;
                //decode wrap around
                position = (position + 26) % 26;
                char newChar = alphabet[position];
                decryptedMessageArray[i] = newChar;

            }

            string decodeMsg = String.Join("", decryptedMessageArray);
            Console.WriteLine($"The decrypted word is {decodeMsg}");

        }
    }
}