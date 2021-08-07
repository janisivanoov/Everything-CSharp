using System;
using System.Collections;
using System.Collections.Generic;

namespace Working_with_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Telsa";
            car1.Model = "Model S";
            car1.VIN = "A12345";
            Car car2 = new Car();
            car2.Make = "Volkswagen";
            car2.Model = "Tiguan";
            car2.VIN = "B12345";
            Book b1 = new Book();
            b1.Author = "Conor McGregor";
            b1.Title = "How to lose figth but win world";

            ArrayList myArrayList = new ArrayList();
            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);
            myArrayList.Remove(b1);
            foreach (Car car in myArrayList)
            {
                Console.WriteLine(car.Make);
            }

            List<Car> myList = new List<Car>();
            myList.Add(car1);
            myList.Add(car2);
            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            Dictionary<string, Car> myDictionary = new Dictionary<string, Car>();
            myDictionary.Add(car1.VIN, car1);
            myDictionary.Add(car2.VIN, car2);
            Console.WriteLine(myDictionary["B12345"].Make);

            List<Car> myList1 = new List<Car>()
            {
                new Car{ Make = "Tesla", Model = "Model S", VIN = "A12345"},
                new Car{Make = "Volkswagen", Model ="Tiguan", VIN = "B12345"}
            };

            Console.ReadLine();
        }
    }
    class Car
    {
        public string VIN
        {
            get;
            set;
        }
        public string Make
        {
            get;
            set;
        }
        public string Model
        {
            get;
            set;
        }
    }
    class Book
    {
        public string Title
        {
            get;
            set;
        }
        public string Author
        {
            get;
            set;
        }
    }
}
