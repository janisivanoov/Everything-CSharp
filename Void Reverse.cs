using System;

namespace Void_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            Reverse();
            Console.ReadLine();
        }
        private static void Reverse()
        {
            string message = "Hello there";
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            foreach(char item in messageArray)
            {
                Console.WriteLine(item);
            }
        }
    }
}
