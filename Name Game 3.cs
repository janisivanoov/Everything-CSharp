using System;

namespace Name_Game_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to name game 3!");
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter city where you born: ");
            string city = Console.ReadLine();
            ReverseString(firstName);
            ReverseString(lastName);
            ReverseString(city);
            Console.ReadLine();
        }
        private static void ReverseString(string message)
        {
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach(char item in messageArray)
            {
                Console.Write(item);
            }
            Console.Write(" ");
        }
    }
}
