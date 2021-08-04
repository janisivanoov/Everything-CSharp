using System;

namespace Try_To_Understand_Scope
{
    class Program
    {
        private static string k = "";
        static void Main(string[] args)
        {
            string j = "";
            for(int i=0; i< 10; i++)
            {
                j = i.ToString();
                k = i.ToString();
                Console.WriteLine(i);
            }
            Console.WriteLine("Outside of the for: " + k);
            Console.Write("Outside of the for: " + j);
            Method();
            Car myCar = new Car();
            myCar.Do();
            Console.ReadLine(); 
        }
        static void Method()
        {
            Console.WriteLine("Value of k from the method: " + k);
        }
    }
    class Car
    {
        public void Do()
        {
            Console.WriteLine(Method());
        }
        private string Method()
        {
            return "Hola amigo";
        }
    }
}
