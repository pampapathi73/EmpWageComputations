﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblems
{
    class EmpWageProblem
    {
        const int Emp_Full_Time = 1;
        const int Emp_Part_Time = 2;
        public int Wage_Per_Hours = 20;
        public int empHrs = 0;

        public void Attendence()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            switch (empCheck)
            {
                case Emp_Full_Time:
                    empHrs = 8;
                    break;

                case Emp_Part_Time:
                    empHrs = 4;
                    break;

                default:
                    empHrs = 0;
                    break;
            }
            int EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine(EmployeeWage);


        }
    }
    }
