using System;

namespace For__do_while__if__else__foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            string value1 = Console.ReadLine();
            double value = double.Parse(value1);
            if (value == 1)
            {
                Console.WriteLine("One");
            }
            else if(value == 2)
            {
                Console.WriteLine("Two");
            }
            else
            {
                Console.WriteLine("Other number");
            }
            Console.WriteLine(value == 3 ? "Three" : "Not three");

            var loopCounter = 0;
            while(loopCounter > 0)
            {
                Console.WriteLine("1");
            }
            do
            {
                Console.WriteLine("2");
            } while (loopCounter > 0);

            var strings = new[]
            {
                "String 1", "String 2", "String 3"
            };
            for(int i = 0; i<strings.Length; i++)
            {
                Console.WriteLine(strings[i]);
            }
        }
    }
    class Class1
    {
        void x()
        {
            var list = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            foreach(var item in list)
            {
                if(item == 5)
                {
                    goto label;
                    throw new Exception();
                    continue;
                }
            }
        label:
            return;
        }
    }
    public class y
    {
        public void x()
        {
            var animal = new Animal();
            var dog = new Dog();
            var poodle = new Poodle();

            TakeAnimal(poodle);
        }
        public void TakeAnimal(Animal a)
        {
            a.Temp = 10;
            if(a is Dog)
            {
                var dog = a as Dog;
                if(dog != null)
                {
                    dog.Name = "Oskar";
                }
            }
        }
    }
    public class Animal { public int Temp { get; set; } }
    public class Dog : Animal { public string Name { get; set; } }
    public class Poodle : Dog { public string Groomer { get; set; } }
}
