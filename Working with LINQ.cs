using System;
using System.Collections.Generic;
using System.Linq;

namespace Working_with_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>
            {
                new Car{VIN="A1",Make="BMW",Model = "E50", Price = 20000, Year = 1999},
                new Car{VIN="B1",Make="Ford",Model = "Escape", Price = 34000, Year = 2004},
                new Car{VIN="C1",Make="Volkswagen",Model = "Tiguan", Price = 17000, Year = 2014},
                new Car{VIN="D1",Make="Tesla",Model = "Model Y", Price = 49000, Year = 2020},
                new Car{VIN="E1",Make="BMW",Model = "E50i", Price = 25000, Year = 1987}
            };
            var bmws = from car in myCars where car.Make == "BMW" select car;
            var bmws1 = myCars.Where(p => p.Make == "BMW" && p.Year == 1999);
            var orderedCar = myCars.OrderByDescending(p => p.Year);
            var firstBMW = myCars.First(p => p.Make == "BMW");
            Console.WriteLine(firstBMW.VIN);

            Console.WriteLine(myCars.TrueForAll(p => p.Year > 2012));

            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.Price));

            myCars.ForEach(p => p.Price -= 999);

            myCars.ForEach(p => Console.WriteLine("{0} {1:C}", p.VIN, p.Price));

            Console.WriteLine(myCars.Exists(p => p.Model == "Model Y"));
            Console.WriteLine(myCars.Sum(p => p.Price));

            Console.WriteLine(myCars.GetType());
            var orderedCars = myCars.OrderByDescending(p => p.Year);
            Console.WriteLine(orderedCars.GetType());

            Console.WriteLine(myCars.GetType());

            var newCars = from car in myCars
                          where car.Make == "BMW" 
                          select new
                          {
                              car.Make, car.Model
                          };
            Console.WriteLine(newCars.GetType());

            foreach(var car in orderedCar)
            {
                Console.WriteLine("{0}{1}", car.Year, car.Model, car.VIN);
            }
            foreach(var car in bmws1)
            {
                Console.WriteLine("{1} {0}", car.Model, car.VIN);
            }
            foreach(var car in bmws)
            {
                Console.WriteLine("{0} {1}", car.Model, car.VIN);
            }
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
        public int Year
        {
            get;
            set;
        }
        public double Price
        {
            get;
            set;
        }
    }
}
