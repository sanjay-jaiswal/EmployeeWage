using System;

namespace EmployeeWage
{
   class Program
    {
        //Constants declaration
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
       {
            Console.WriteLine("---Welcome to Employee wage Program---");

            //Variables declaration
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            //Calculating wages
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case IS_PART_TIME:
                    empHrs = 8;
                    break;
                case IS_FULL_TIME:
                    empHrs = 4;
                    break;
                default:
                    empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Employee wage is : " +empWage);
            Console.ReadKey();
      }
    }
}
