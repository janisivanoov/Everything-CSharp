using System;

namespace Array_4_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] {"Alex","Sofia","Janis"};
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine(names[i]);
            }
            Console.ReadLine();
        }
    }
}
