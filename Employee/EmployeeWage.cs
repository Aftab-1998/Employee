﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
       public class EmployeeWage
    {
        //constant
        int IS_FULL_TIME = 1;
        int EMP_RATE_PER_HOUR = 20;
        int IS_PART_TIME = 0;
        //variables
        int empHrs = 0;
        int empWage = 0;
        public void Attendance()
        {
            Random rand = new Random();
            int rem = rand.Next() % 2;
            if (rem > 0)
            {
                Console.WriteLine("Present");
            }
            else
            {
                Console.WriteLine("Absent");
            }

        }
       
        
            public double DailyWage()
            {
                Random random = new Random();
                //Computation
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
                Console.WriteLine("Emp Wage : " + empWage);
                return empWage;

            }
        public void PartTime()
        {
            Random random = new Random();
            int empcheck = random.Next(0, 3);
            if (empcheck == IS_PART_TIME)
            {
                empHrs = 4;
            }
            else if (empcheck == IS_FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("Emp Wage : " + empWage);
        }
    }



    
}
