using System;

namespace lab4_4
{
    class Program
    {
        static void line()
        {
            Console.WriteLine("========================================================================================================================================================================");
        }
        static void comparable()
        {
            line();

            Employee[] employees = new Employee[5];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Введіть {i + 1} робітника та його вік: ");
                employees[i] = new Employee(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()), 50000);
                Console.WriteLine($"{employees[i].Name} - {employees[i].Age} років");
                line();
            }

            Console.Write("Виберіть перший об'єкт для порівняння: ");
            int fst = Int32.Parse(Console.ReadLine());
            Console.Write("Виберіть другий об'єкт для порівняння: ");
            int sec = Int32.Parse(Console.ReadLine());
            fst -= 1; sec -= 1;

            Console.WriteLine(employees[fst].CompareTo(employees[sec]));
        }
        static void comparer()
        {
            line();

            Employee[] employees = new Employee[5];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Введіть {i + 1} робітника, його вік та зарплату: ");
                employees[i] = new Employee(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()),
                                    Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"{employees[i].Name} ({employees[i].Age} років)- {employees[i].Salary} гривень");
                line();
            }

            Console.Write("Виберіть перший об'єкт для порівняння: ");
            int fst = Int32.Parse(Console.ReadLine());
            Console.Write("Виберіть другий об'єкт для порівняння: ");
            int sec = Int32.Parse(Console.ReadLine());
            fst -= 1; sec -= 1;

            Console.WriteLine(employees[fst].Compare(employees[fst], employees[sec]));
        }
        static void enumerator()
        {
            line();
            Employee[] employees = new Employee[5];

            for (int i = 0; i < employees.Length; i++)
            {
                Console.WriteLine($"Введіть {i + 1} робітника та його зарплату: ");
                employees[i] = new Employee(Console.ReadLine(), 0, Convert.ToInt32(Console.ReadLine()));
                Console.WriteLine($"{employees[i].Name} - {employees[i].Salary} гривень");
                line();
            }

            Array.Sort(employees, new Employee());

            Employee.Employees EmplEnum = new Employee.Employees(employees);
            foreach (var employee in EmplEnum)
            {
                Console.WriteLine("{0}: {1} гривень", employee.Name, employee.Salary);
            }
            line();
        }

        static void Main(string[] args)
        {
            line();
            Console.WriteLine("\t\t\t\t\t\t\tWelcome to LAB-4...");

            while (true)
            {
                Console.WriteLine("1. Метод IComparable");
                Console.WriteLine("2. Метод IComparer");
                Console.WriteLine("3. Метод IEnumerator");

                line();
                Console.Write("Choose the option: ");
                int task = Int32.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1: comparable(); break;
                    case 2: comparer(); break;
                    case 3: enumerator(); break;
                }

                if (task > 3 || task <= 0)
                {
                    Console.WriteLine("Closing the program...");
                    break;
                }
            }
        }
    }
}