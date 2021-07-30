using System;

namespace Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            FirstName();
            SecondName();
            placeOfBirth();
        }
        public static void FirstName()
        {
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();
            char[] charArray1 = firstName.ToCharArray();
            Array.Reverse(charArray1);
            foreach(char firstNameChar in charArray1)
            {
                Console.WriteLine(firstNameChar);
            }
        }
        private static void SecondName()
        {
            Console.WriteLine("Enter your second name: ");
            string secondName = Console.ReadLine();
            char[] charArray1 = secondName.ToCharArray();
            Array.Reverse(charArray1);
            foreach (char secondNameChar in charArray1)
            {
                Console.WriteLine(secondNameChar);
            }
        }
        private static void placeOfBirth()
        {
            Console.WriteLine("Enter your place of birth");
            string placeOfBirth = Console.ReadLine();
            char[] charArray1 = placeOfBirth.ToCharArray();
            Array.Reverse(charArray1);
            foreach (char placeOfBirthChar in charArray1)
            {
                Console.WriteLine(placeOfBirthChar);
            }
        }
    }
}
