using System;

namespace Name_Game_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to name game 4 again");
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter a city where you born: ");
            string city = Console.ReadLine();
            DisplayResult(ReverseString(firstName),ReverseString(lastName),ReverseString(city));
        }
        private static string ReverseString(string message){
            char[] messageArray = message.ToCharArray();
            Array.Reverse(messageArray);
            return String.Concat(messageArray);
        }
        private static void DisplayResult( string reversedFirstName, string reversedLastName, string reversedcity)
        {
            Console.Write(String.Format("{0} {1} {2}", reversedFirstName, reversedLastName, reversedcity));
        }
    }
}
