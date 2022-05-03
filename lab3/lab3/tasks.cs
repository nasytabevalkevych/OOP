using System;
using lab3;

namespace Lab3
{
    public class Tasks
    {

        public void Welcome()
        {
            Console.WriteLine("Lab-3, Var-2");
            Console.WriteLine("Developer: Byvalkevych Anastasia Victorivna, gr - 13\n");

        }

        public void Menu()
        {
            int command;
            Console.WriteLine("                         MENU");
            Console.WriteLine("-----------------------------------------------------------");
            for (int i = 1; i < 10; i++)
                Console.WriteLine($"{i}. Task-{i}.                ");
            Console.WriteLine("10. Exit");
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine();
            do
            {
                Console.Write("Select command to execute:\n ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1: Task1(); break;
                    case 2: Task2(); break;
                    case 3: Task3(); break;
                    case 4: Task4(); break;
                    case 5: Task5(); break;
                    case 6: Task6(); break;
                    case 7: Task7(); break;
                    case 8: Task8(); break;
                    case 9: Task9(); break;
                    default: Console.WriteLine("Unknown command - repeat again"); break;
                }
            } while (command != 10);

        }
        Student Student1 = new Student();
        Student Student2 = new Student("Ivan", "Ivanov", "Software Engineering", 80, 1);

        Department Department1 = new Department();
        Department Department2 = new Department("Department of programming systems and technologies", 50, 2000, "Software Engineering", "A");
        public void Task1()
        {
            Console.WriteLine("Classes are created!");
            Console.WriteLine("------------------------------------------------------------------");
        }
        public void Task2()
        {
            Console.WriteLine("Constructors without parameters: ");
            Student1.OutputValues();
            Console.WriteLine("------------------------------------------");
            Department1.OutputValues();
            Console.WriteLine("------------------------------------------------------------------");
        }
        public void Task3()
        {
            Console.WriteLine("Constructors with parameters: ");
            Student2.OutputValues();
            Console.WriteLine("------------------------------------------");
            Department2.OutputValues();
            Console.WriteLine("------------------------------------------------------------------");
        }
        public void Task4()
        {
            Console.WriteLine("Using of set and get (name of student and putting department name on screen):");
            Student1.firstName = "Andrey"; // using set
            Student1.OutputValues();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(Department2.nameDepartment);// using get
            Console.WriteLine("------------------------------------------------------------------");
        }
        public void Task5()
        {
            Console.WriteLine("Enter values for new student:");
            Student1.EnterValues();
            Student1.CreatingArray();
            Student1.OutputArray();
            Student1.Suma();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Information changed succesfully!");
            Console.WriteLine("------------------------------------------");
            Student1.OutputValues();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Enter values for new Department:");
            Department1.EnterValues();
            Department1.NumStd();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Information changed succesfully!");
            Console.WriteLine("------------------------------------------");
            Department1.OutputValues();
            Console.WriteLine("------------------------------------------------------------------");
        }

        public void Task6()
        {
            Console.WriteLine("Write to text file\n");
            Console.WriteLine("------------------------------------------");
            Student1.WriteToTXT();
            Student1.ChangeNumberOf();
            Console.WriteLine("------------------------------------------");
            Department1.WriteToTXT();
            Department1.ChangeNumberOf1();
            Console.WriteLine("------------------------------------------");
        }


        public void Task7()
        {
            Student.ContestWork contestWork = new Student.ContestWork();
            contestWork.Compliance();
            Console.WriteLine("------------------------------------------");
            contestWork.QualityWork();
            Console.WriteLine("------------------------------------------");

        }
        public void Task8()
        {
            Console.WriteLine("Class Department is partial!");
        }
        public void Task9()
        {
            СreativeWork creativeWork = new СreativeWork();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Matrix(BubbleSort)");
            creativeWork.Task1();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("String");
            creativeWork.Task2();
        }
    }
}


