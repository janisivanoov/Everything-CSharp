using System;

namespace Array_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 12, 11, 4, 6, 1, 8 };
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadLine();
        }
    }
}
