using System;

namespace EmployeeWage
{
   class Program
    {
       static void Main(string[] args)
       {
            //Constants declaration
            int IS_FULL_TIME = 1;
            int EMP_RATE_PER_HOUR = 20;
            //Variables declaration
            int empHrs = 0;
            int empWage = 0;

            //Calculating wages
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is : " +empWage);
            Console.ReadKey();
      }
    }
}
