using System;

namespace lab4_2
{
    class Program
    {
        static void line()
        {
            Console.WriteLine("========================================================================================================================================================================");
        }
        static void EnterEngineer()
        {
            Console.WriteLine(); line();

            IPerson engineer = new Engineer();
            engineer.Enter();
            engineer.Show();

            Console.WriteLine(); line();
            engineer.ProfSkills();

            Console.WriteLine(); line();
        }
        static void EnterEmployee()
        {
            Console.WriteLine(); line();

            IPerson employee = new Employee();
            employee.Enter();
            employee.Show();

            Console.WriteLine(); line();
            employee.ProfSkills();

            Console.WriteLine(); line();
        }
        static void EnterPerson()
        {
            Console.WriteLine(); line();

            IPerson person = new Person();
            person.Enter();
            person.Show();

            Console.WriteLine(); line();
        }

        static void Main(string[] args)
        {
            line();
            Console.WriteLine("\t\t\t\t\t\t\tWelcome to LAB-4...");

            while (true)
            {
                Console.WriteLine("1. Продемонструвати доступ до класу Engineer");
                Console.WriteLine("2. Продемонструвати доступ до класу Employee");
                Console.WriteLine("3. Продемонструвати доступ до класу Person");

                line();
                Console.Write("Choose the option: ");
                int task = Int32.Parse(Console.ReadLine());

                switch (task)
                {
                    case 1: EnterEngineer(); break;
                    case 2: EnterEmployee(); break;
                    case 3: EnterPerson(); break;
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