using System;

namespace lab4
{
    class Program
    {
        static void line()
        {
            Console.WriteLine(
                "=============================================================================");
        }
        static void task1()
        {
            line();
            //                  Class Engineer
            Console.WriteLine("\t\t Завдання 1.\n\t Створимо два класи та їх базовий.\n");
            Console.WriteLine("\tСтворюємо клас Engineer, який успадкує клас Person\n");

            Engineer engineer = new Engineer("Олег", "менеджер", 30, 10, 50000,
                "багато успішних проектів", "хороший лідер, критичне мишлення", "розумний, досвідчений");
            engineer.Show();
            //                  Class Employee
            Console.WriteLine();
            Console.WriteLine("\tСтворюємо клас Employee, який успадкує клас Person" +
                              "\n\tДавайте тепер введемо значення з клавіатури.\n");

            Employee employee = new Employee();
            employee.Enter();
            Console.WriteLine();
            employee.Show();
            Console.WriteLine();
            line();
        }
        static void task2()
        {
            Console.Clear();
            line();
            //                  Class Engineer
            Console.WriteLine("\t\t Завдання 2.\n\t Створимо методи для визначення професійних навичок у класах" +
                              " Engineer та Employee.\n");
            Console.WriteLine("\tСтворимо метод у класі Engineer, який визначить творчі навички інженера.\n");
            Engineer engineer = new Engineer();
            engineer.ProfSkills();
            Console.WriteLine();
            line();
            //                  Class Employee
            Console.WriteLine();
            Console.WriteLine("\tСтворимо метод у класі Employee, який визначить технічну наладку обладнання робітником.\n");
            Employee employee = new Employee();
            employee.ProfSkills();
            Console.WriteLine();
            line();
        }

        static void Main(string[] args)
        {
            line();
            Console.WriteLine("\t\t\t\t\t\t\tWelcome to LAB-4...");

            while (true)
            {
                Console.WriteLine("1. Створити два класи, які успадковують базовий");
                Console.WriteLine("2. Створити в них методи для визначення творчих навичок");

                line();
                Console.Write("Choose the option: ");
                int task = Int32.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1:
                        task1();
                        break;
                    case 2:
                        task2();
                        break;
                }

                if (task > 2 || task <= 0)
                {
                    Console.WriteLine("Closing the program...");
                    break;
                }
            }
        }

    }
}