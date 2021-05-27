using System;

namespace EmpWageProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Program"); //main
            EmpWageProblem EmployeeWage = new EmpWageProblem();
            EmployeeWage.Attendence();
            Console.ReadKey();
        }
    }
}
