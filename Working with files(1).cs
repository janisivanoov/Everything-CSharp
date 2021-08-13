using System;
namespace Working_with_files
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello there";
            System.IO.WriteAllText(@"C:\Example\Example.txt", text);
            Console.ReadLine();
        }
    }
}
