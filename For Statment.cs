using System;

namespace For_Statment_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("We found seven");
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
