using System;

namespace EmployeeWage
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Employee wage Program---");
            EmpWageBuilderArray empWageBuilderArray = new EmpWageBuilderArray();
            empWageBuilderArray.addCompanyEmpWage("Dmart", 20, 2, 10);
            empWageBuilderArray.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWageBuilderArray.computeEmpWage();
        }
    }
}
