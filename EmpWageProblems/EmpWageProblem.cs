﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmpWageProblems
{
    class EmpWageProblem
    {
        readonly int IS_PRESENT = 1;

        public void Attendance()
        {
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_PRESENT)
                Console.WriteLine("Employee is Present");
            else
                Console.WriteLine("Employee is Absent");

        }
        }
    }
