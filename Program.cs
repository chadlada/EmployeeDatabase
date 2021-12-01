using System;

namespace EmployeeDatabase
{
    class Program
    {
        class Employee
        {
            // public means "this can be seen outside of the class"
            // |
            // |   Type
            // |   |
            // |   |      Name of property
            // |   |      |
            // |   |      |
            // |   |      |
            // v   v      v
            public string Name { get; set; }
            public int Department { get; set; }
            public int Salary { get; set; }
            public int MonthlySalary { get; set; }




            OEOPSOPOPOW









            // This is a *special* method known as a "constructor"
            // The constructor is called when we write a line like: `var bob = new Employee(`
            // The arguments to the method should line up to those below
            //
            //              This will become the employee's name
            //              |               This will become the employee's department
            //              |               |                  This will become the employee's salary
            //              |               |                  |              This will become the employee's monthly salary
            //              |               |                  |              |
            //              v               v                  v              v
            public Employee(string newName, int newDepartment, int newSalary, int newMonthlySalary)
            {
                // In the constructor we should setup the values for any of the properties.
                // Here we will *copy* the values given by the arguments to the corresponding property.
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

        static int ComputeMonthlySalaryFromYearly(int yearlySalary)
        {
            return yearlySalary / 12;
        }

        static void Main(string[] args)
        {
            var graceHopper = new Employee("Grace Hopper", 100, 240_000, 240_000);
            Console.WriteLine(graceHopper.Department);

            var elonMusk = new Employee("Elon Musk", 42, 120_000, 10_000);
            Console.WriteLine(elonMusk.Department);



            DisplayGreeting();

            var name = PromptForString("What is your name? ");

            int department = PromptForInteger("What is your department number? ");

            int salary = PromptForInteger("What is your yearly salary (in dollars)? ");

            int monthlySalary = ComputeMonthlySalaryFromYearly(salary);

            Console.WriteLine($"Hello, {name} you make {monthlySalary} dollars per month.");
        }
    }
}