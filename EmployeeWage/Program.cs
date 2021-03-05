using System;

namespace EmployeeWage
{
   class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---Welcome to Employee wage Program---");
            UC8_ComputeEmpWageForMultipleCompanies.computeEmpWage2("DMart",20,2,10);
            UC8_ComputeEmpWageForMultipleCompanies.computeEmpWage2("Reliance", 10, 4, 20);
        }
    }
}
