using System;

namespace While_simple_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 or 2");
            string answer = Console.ReadLine();
            double ans = double.Parse(answer);
            if (ans == 1)
            {
                do
                {
                    Console.WriteLine("1");
                } while (ans == 1);
            }
            else
            {
                Console.WriteLine("2");
            }
            Console.ReadLine();
        }
    }
}
