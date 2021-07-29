using System;

namespace Naming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            string LastName = Console.ReadLine();
            Console.Write("Hello " + FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
