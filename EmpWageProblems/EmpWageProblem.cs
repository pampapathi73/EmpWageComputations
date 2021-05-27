using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblems
{
    class EmpWageProblem
    {
        readonly int Wage_Per_Hours = 20;
        readonly int Emp_Full_Time = 2;
        readonly int Emp_Part_Time = 1;
        int empHrs;
        int EmployeeWage;
        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            // if (empCheck == IS_PRESENT)
            //{
            //  Console.WriteLine("Employee is Present");
            if (empCheck == Emp_Part_Time)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            EmployeeWage = empHrs * Wage_Per_Hours;
            Console.WriteLine("Employee Full Wage is : " + EmployeeWage);


        }
    }
    }
