using System;

namespace Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Make = "Tesla";
            myCar.Model = "Model Y";
            myCar.Year = 2020;
            myCar.Color = "black";
            Console.WriteLine("My brand new {0}  {1} which was created in {2} in {3} color already on my parking slot", myCar.Make
                , myCar.Model
                , myCar.Year
                , myCar.Color);

            Car mySecondCar;
            mySecondCar = myCar;
            mySecondCar.Model = "Model S";
            mySecondCar.Year = 2019;
            mySecondCar.Color = "blue";
            Console.WriteLine("My brand new {0}  {1} which was created in {2} in {3} color already on my parking slot", myCar.Make
                , mySecondCar.Model
                , myCar.Year
                , myCar.Color);

            Car myThirdCar = new Car();
            Console.WriteLine(myThirdCar.Model);

            Car.Method();

            Console.ReadLine();
        }
    }
    class Car
    {
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
        public decimal Year
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public Car()
        {
            this.Model = "FR--V";
        }
        public Car(string make, string model , decimal year , string color)
        {
            Make = make;
            Model = model;
            Year = year;
            Color = color;
        }
        public static void Method()
        {
            Console.WriteLine("Programm finished");
        }
    }
}
