using System;

namespace If_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y = 3, a = 4, b = 1;
            x = ((y + a) * (a - b));
            if ((x > y) && (a > b))
            {
                Console.WriteLine("((x > y) && (a > b))");
            }
            if ((x > y) || (a > b))
            {
                Console.WriteLine("((x > y) || (a > b))");
            }
            else
            {
                Console.WriteLine("Press Enter to stop");
                Console.ReadLine();
            }
            Console.WriteLine("Programm done");
        }
    }
}
