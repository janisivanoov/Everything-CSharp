using System;

namespace Tets
{
    class Program
    {
        static void Main(string[] args)
        {
            employee EMP = new employee();
            EMP.name = ("Janis");
            EMP.salary = 29999.9M;
            Console.WriteLine("{0} name and salary is {1:C}", EMP.name, EMP.salary);
        }
    }
    class employee
    {
        public string name
        {
            get;
            set;
        }
        public decimal salary
        {
            get;
            set;
        }
    }
}
