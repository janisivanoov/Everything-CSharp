using System;

namespace Quiz_last_version
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello again to our Quiz!");
            Console.Write("Choose 1, 2 or 3: ");
            string answer = Console.ReadLine();
            string message = (answer == "1") ? "house" : "car";
            Console.Write("You win ");
            Console.Write(message);
            Console.Write(" ");
            Console.ReadLine();
        }
    }
}
