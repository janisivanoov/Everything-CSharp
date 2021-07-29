using System;

namespace Quiz_simple_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Quiz");
            Console.Write("Choose 1,2 or 3: ");
            string chooseNumber = Console.ReadLine();
            if (chooseNumber == "1")
            {
                string message = "You won a car!";
                Console.WriteLine(message);
            }
            else if (chooseNumber == "2")
            {
                string message = "You won a house!";
                Console.WriteLine(message);
            }
            else if (chooseNumber == "3")
            {
                string message = "you won cup of tea";
                Console.WriteLine(message);
            }
            else
            {
                string message = "Incorrect input!";
                Console.WriteLine(message);
            }
            Console.ReadLine();
        }
    }
}
