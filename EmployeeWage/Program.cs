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
            empWageBuilderArray.addCompanyEmpWage("Samsung", 25, 5, 22);
            empWageBuilderArray.addCompanyEmpWage("Facebook", 30, 6, 25);
            empWageBuilderArray.computeEmpWage();

            Console.WriteLine("");
            Console.WriteLine("Total wage for Dmart company is= " + empWageBuilderArray.getTotalWage("Dmart"));
            Console.WriteLine("Total wage for Reliance company is= " + empWageBuilderArray.getTotalWage("Reliance"));
            Console.WriteLine("Total wage for Samsung company is= " + empWageBuilderArray.getTotalWage("Samsung"));
            Console.WriteLine("Total wage for Facebook company is= " + empWageBuilderArray.getTotalWage("Facebook"));
        }
    }
}
