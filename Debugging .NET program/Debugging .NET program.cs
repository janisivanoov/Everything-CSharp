using System;
using System.Diagnostics;

namespace DotNetDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibonacci(5);
            Console.WriteLine(result);
            Console.ReadKey(true);
            int count = 0;
            if (count == 0)
            {
                Debug.WriteLine("The count is 0 and this may cause an exception.");
            }
            bool errorFlag = false;
            System.Diagnostics.Trace.WriteIf(errorFlag, "Error in AppendData procedure.");
            System.Diagnostics.Debug.WriteIf(errorFlag, "Transaction abandoned.");
            System.Diagnostics.Trace.Write("Invalid value for data request");
            int IntegerDivide(int dividend, int divisor)
            {
                Debug.Assert(divisor != 0, $"nameof(divisor) is 0 and will cause an exception.");

                return dividend / divisor;
            }
            Debug.WriteLine($"Entering {nameof(Fibonacci)} method");

        }
        static int Fibonacci(int n)
        {
            int n1 = 0;
            int n2 = 1;
            int sum = 0;

            for (int i = 2; i <= n; i++)
            {
                sum = n1 + n2;
                n1 = n2;
                n2 = sum;
            }
            return n == 0 ? n1 : n2;
        }
    }
}