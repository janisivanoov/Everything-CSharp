using System;

namespace Classes_simple_
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.Factory_Name = "Ferrari";
            myCar.Model = "Old one";
            myCar.Year = 2000;
            myCar.Color = "Gold";
            Console.WriteLine("{1},{3},{2},{0}", myCar.Factory_Name, myCar.Model, myCar.Year, myCar.Color);
            decimal value = DetermineMarketValue(myCar);
            Console.WriteLine("{0:C}", value);
            Console.ReadLine();
        }
    }
    private static decimal DetermineMarketValue(Car car)
    {
        decimal carValue = 999.9M;
        return carValue;
    }
    class Car
    {
        public string Factory_Name { 
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
        public string Color
        {
            get;
            set;
        }
        public decimal DetermineMarketValue()
        {
            decimal carValue;
            if(Year > 2000)
            {
                carValue = 999.9M;
            }
            else
            {
                carValue = 888.8M;
            }
            return carValue;
        }
    }
}
