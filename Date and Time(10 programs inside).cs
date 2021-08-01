using System;

namespace Time_And_Date
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToString());
            Console.ReadLine();
            /*
            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortDateString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToShortDateString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToLongDateString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.ToLongTimeString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.AddDays(3).ToLongDateString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.AddHours(-3).ToLongDateString());
            Console.ReadLine();

            DateTime myValue = DateTime.Now;
            Console.WriteLine(myValue.Month);
            Console.ReadLine();

            DateTime myBirthday = new DateTime(2004,8,12);
            Console.WriteLine(myBirthday.ToShortDateString);
            Console.ReadLine();

            DateTime myBirthday = DateTime.Parse("8/12/2004");
            TimeSpan myAge = DateTime.Now.Substract(myBirthday);
            Console.WriteLine(myAge.TotalDays);
            Console.ReadLine();
            */
        }
    }
}
