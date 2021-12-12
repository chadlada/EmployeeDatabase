using System;
using System.Collections.Generic;

namespace EmployeeDatabase
{
    class Program
    {
        class Employee
        {
            public string Name;
            public int Department;
            public int Salary;
            public int MonthlySalary;

            public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
            {
                Name = newName;
                Department = newDepartment;
                Salary = newSalary;
                MonthlySalary = newMonthlySalary;
            }


        }
        static void DisplayGreeting()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("    Welcome to Our Employee Database    ");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
        }

        static string PromptForString(string prompt)
        {
            Console.Write(prompt);
            var userInput = Console.ReadLine();
            return userInput;
        }

        static int PromptForInteger(string prompt)
        {
            Console.Write(prompt);
            int userInput;
            var isThisGoodInput = Int32.TryParse(Console.ReadLine(), out userInput);

            if (isThisGoodInput)
            {
                return userInput;
            }
            else
            {
                Console.WriteLine("Sorry, that isn't a valid input, I'm using 0 as your answer.");
                return 0;
            }

        }

        static int MonthlySalaryFromYearly(int yearlySalary)
        {
            return yearlySalary / 12;
        }



        static void Main(string[] args)
        {
            var graceHopper = new Employee("Grace Hopper", 100, 240_000, 20_000);
            Console.WriteLine(graceHopper.Department);

            DisplayGreeting();


            var name = PromptForString("What is your name?");
            int department = PromptForInteger("What is your department?");
            int salary = PromptForInteger("What is your yearly salary?");
            int monthlySalary = MonthlySalaryFromYearly(salary);
            Console.WriteLine($"Hello, {name} you make {monthlySalary} dollars per month.");
        }
    }
}