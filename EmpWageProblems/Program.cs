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
            Attendence("DMart", 20, 2, 100);
            Attendence("Reliance", 10, 4, 20);
            Console.ReadKey();
        }
    }
}
