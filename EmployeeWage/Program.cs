using System;

namespace EmployeeWage
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Employee wage Program---");
            EmpWageBuilderObject dMart = new EmpWageBuilderObject("DMart", 20, 2, 10);
            EmpWageBuilderObject reliance = new EmpWageBuilderObject("Reliance", 10, 4, 20);
            dMart.computeEmpwage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpwage();
            Console.WriteLine(reliance.toString());
        }
    }
}
