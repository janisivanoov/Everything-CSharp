using System;

namespace Name_Game_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome here");
            Console.Write("Enter your name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter your lastname: ");
            string lastName = Console.ReadLine();
            char[] charArray1 = firstName.ToCharArray();
            Array.Reverse(charArray1);
            foreach(char firstnameChar in charArray1)
            {
                Console.WriteLine(firstnameChar+" ");
            }
            char[] charArray2 = lastName.ToCharArray();
            Array.Reverse(charArray2);
            foreach(char secondnameChar in charArray2)
            {
                Console.WriteLine(secondnameChar);
            }
            Console.ReadLine();
        }
    }
}
