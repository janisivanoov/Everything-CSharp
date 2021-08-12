using System;

using System.Timers;

namespace Events_and_Event_Driven_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer myTimer = new Timer(2000);
            myTimer.Elapsed += MyTimer_Elapsed;
            myTimer.Start();
            Console.ReadLine();
        }
        private static void MyTimer_Elapsed(object sender, ElapsedEventArgs ev)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Elapsed: {0:HH:mm:ss.fff}", ev.SignalTime);
        }
    }
}
