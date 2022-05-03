//1.Вивести на консоль власні анкетні дані: прізвище, ім 'я, вік, група, курс, e-mail.

//Обчислення значення поліному p = a*x^4  b*x^3 + c*x + d. Значення a, b, c, d – дійсні числа, які слід ініціалізувати у функції, значення змінної x увести з консолі.
//Результат вивести на консоль. 

//2.За даними, що введені з консолі, визначити значення виразу, використовуючи математичні функції, і вивести результат на консоль.

//3.Обчислити значення функції в точці х, значення якої ввести з консолі:

//4.Написати функцію, яка в залежності від порядкового номера дня тижня (1,2,...7) виводить на екран його назву (понеділок,...)

//5.Обчислити суму чисел в заданому у функції діапазоні. Значення чисел вводити з консолі.
//Якщо значення, що вводиться, виходить за межі заданого діапазону, вивести повідомлення про помилку і повторити введення. Не застосовувати масиви.

using System;

namespace lab1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Lab-1, var-2");
            Console.WriteLine("Developer: Byvalkevych Anastasia Victorivna, gr - 13\n");
            Menu();
        }
        static void Menu()
        {
            char command;
                Console.WriteLine("                               MENU");
                Console.WriteLine("1.1. Own personal data.");
                Console.WriteLine("1.2. Calculating p = a*x^4 - b*x^3 + c*x + d.");
                Console.WriteLine("2. Determine the value: x=(a + b)^2 / (sin c - cosd)^1/2");
                Console.WriteLine();
                Console.WriteLine("                                             | 4x-1, x>0");
                Console.WriteLine("3. Calculate the value of the function: F(x)=| 25x+10, x<0");
                Console.WriteLine("                                             | 0, x=0");
                Console.WriteLine();
                Console.WriteLine("4. Numbers of the day of the week (1,2, ... 7)");
                Console.WriteLine("5. Calculate the sum of numbers in the range specified in the function");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine();
            do
            {
                Console.WriteLine("Select command to execute:");
                command = (char)Console.Read();
                Console.ReadLine();
                switch (command)
                {
                    case '1': Task1(); break;
                    case '2': Task2(); break;
                    case '3': Task3(); break;
                    case '4': Task4(); break;
                    case '5': Task5(); break;
                    default: Console.WriteLine("Unknown command - repeat again"); break;
                }
            } while (command != '6');
        }

        static void Task1()
        {
            string lastn, firstn, e_mail;
            int gr, age, course;

            Console.WriteLine("1.1. Last name: ");
            lastn = Console.ReadLine();
            Console.WriteLine("     First name: ");
            firstn = Console.ReadLine();
            Console.WriteLine("     Age: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("     Group(number): ");
            gr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("     Course: ");
            course = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("     E-mail: ");
            e_mail = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Last name --" + lastn + "\nFirst name --" + firstn + "Age --" + age + "\nGroup(number) -- " + gr + "\nCourse -- " + course + "\nE-mail -- " + e_mail);
            Console.WriteLine();
            Console.WriteLine("1.2. p = a*x^4 - b*x^3 + c*x + d.");
            int x;
            double a = 2.5, b = 1.2, c = 10.0, d=5.0;
            Console.WriteLine("a = 2.5, b = 1.2, c = 10.0, d=5.0");
            Console.WriteLine("Input x");
            x = Convert.ToInt32(Console.ReadLine());
            double p = a * Math.Pow((double)x, (double)4) + b * Math.Pow((double)x, (double)3) + c * x+d;
            Console.WriteLine("Your p = " + p);
            Console.WriteLine("------------------------------------------------------------------");
        }
        static void Task2()
        {
            double x, a, b, c, d;
            Console.WriteLine("x = (a + b)^2 / (sin c - cosd)^1/2");
            Console.WriteLine("Input a:");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input b:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input c:");
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input d:");
            d = Convert.ToDouble(Console.ReadLine());
            if (d > c && d != c)
            {
                x = Math.Pow((double)(a + b), (double)2) / (Math.Sqrt(Math.Sin(c) - Math.Cos(d)));
                Console.WriteLine("Your x = " + x);
            }
            else
                Console.WriteLine("Indefinitely");
            Console.WriteLine("------------------------------------------------------------------");
        }
        static void Task3()
        {
            double y;
            Console.WriteLine("      | 4x-1, x>0");
            Console.WriteLine(" F(x)=| 25x+10, x<0");
            Console.WriteLine("      | 0, x=0");
            Console.WriteLine("Input x");
            double x = double.Parse(Console.ReadLine());
            if (x == 0)
            {
                Console.WriteLine("F(x)=0");
            }
            else if (x < 0)
            {
                y = 25 * x + 10;
                Console.WriteLine("F(x)=" + y);
            }
            else
            {
                y = 4 * x - 1;
                Console.WriteLine("F(x)=" + y);
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
        static void Task4()
        {
            Console.WriteLine("Write a number from 1-7 to find out the day of the week.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Mondey"); ; break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                default: Console.WriteLine("Unknown"); break;
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
        static void Task5()
        {
            Console.WriteLine("Input numbers to calculate the sum:");
            int sum = 0,i;
            for (i = 0; i <= 10; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (number == 0)
                {
                    Console.WriteLine("Your sum = " + sum);
                }
                if (number> 10)
                {
                    Console.WriteLine("Input numbers(<10)");
                    break;
                } 
            }
            Console.WriteLine("------------------------------------------------------------------");
        }
       
    }
}