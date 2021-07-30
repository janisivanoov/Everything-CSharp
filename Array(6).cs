using System;

namespace Array_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Welcome to my github" +
                "I'm a junior programmer in C++ and C#";
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            foreach(char textChar in charArray)
            {
                Console.WriteLine(textChar);
            }
            Console.ReadLine();
        }
    }
}
