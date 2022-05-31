using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Employeelerin sayini daxil edin");
            string countStr = Console.ReadLine();
            int count = Convert.ToInt32(countStr);

            Employee[] employees = new Employee[count];


            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"{i + 1}.Employeenin adini daxil ele");
                string nameEmployee = Console.ReadLine();

                Console.WriteLine($"{i + 1}.Employeenin positionunu daxil ele");
                string positionEmployee = Console.ReadLine();

                Console.WriteLine($"{i + 1}.Employeenin maasini daxil ele");
                int salaryEmployee = int.Parse(Console.ReadLine());

                employees[i] = new Employee()
                {
                    FullName = nameEmployee,
                    Position = positionEmployee,
                    Salary = salaryEmployee

                };
            }

            Console.WriteLine("Filterleme aparmaq isteyirsen? he ya da yox yaz");
            string answer = Console.ReadLine().ToUpper();
            if (answer == "HE")
            {
                Console.WriteLine("Maximum salary daxil ele");
                int maxSalary = int.Parse(Console.ReadLine());
                Console.WriteLine("Minimum salary daxil ele");
                int minSalary = int.Parse(Console.ReadLine());
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i].Salary > minSalary && employees[i].Salary < maxSalary)
                    {
                        Console.WriteLine($"{employees[i].FullName}, {employees[i].Position}, Salary: {employees[i].Salary}");
                    }
                }
            }
            else if (answer == "YOX")
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    Console.WriteLine($"{employees[i].FullName}, {employees[i].Position}, Salary: {employees[i].Salary}");
                }
            }
            else
            {
                Console.WriteLine("Proqram xeta verdi");
            }
        }
    }
}

