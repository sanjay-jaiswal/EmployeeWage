﻿using System;

namespace EmployeeWage
{
   class Program
    {
       static void Main(string[] args)
       {
            int IS_FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(2);

            //Checking emp is present or not
            if (empCheck == IS_FULL_TIME)
            Console.WriteLine("Employee is Present");
            else
            Console.WriteLine("Employee is Absent");
            Console.ReadKey();
      }
    }
}
