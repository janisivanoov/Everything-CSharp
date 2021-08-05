using System;
using ClassLibrary1;
namespace MyClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Class_Library myClass_Library = new Class_Library();
            string value = myClass_Library.ScrapeWebPage("https://www.unic.ac.cy/");
            Console.WriteLine(value);
            Console.ReadLine();
        }
    }
}
