using System;

namespace Array_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] { "Alex", "Sofia", "Janis" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
        }
    }
}
