// Для створення масиву і матриці використати методи класу Random. Для виконання математичних обчислень використати клас Math
//1.	Згенерувати елементи одновимірного масиву, задавши їх кількість з консолі.
//Відсортувати згенерований масив за зростанням значень його елементів алгоритмом бульбашкового сортування.
//Вивести масив до та після сортування на консоль.

//2.	Побудувати новий одновимірний масив простих чисел, використавши алгоритм Ератосфена, та вивести їх на консоль.

//3.	Об’єднати згенерований раніше масив з масивом простих чисел.
//Обчислити суму елементів масиву, середнє арифметичне елементів, min і max елементів масиву, використавши методі класу Math.
//Результати вивести на консоль.

//4.	Вивести на консоль індекси усіх повторень шуканого елемента масиву, застосувавши метод лінійного пошуку. Значення шуканого елемента ввести з консолі 

//5.	Вивести на консоль індекс елемента, значення якого задане з консолі, застосувавши метод бінарного пошуку.
//У разі його відсутності в масиві ви вести відповідне повідомлення. Модифікувати функцію двійкового пошуку у масиві, використавши метод  BinarySearch класу Array

//6.	Згенерувати матрицю, i–й рядок якої визначає номер співробітника, j-й стовпчик якої визначає номер місяця року.
//Кількість співробітників задати з консолі. Значення на перетині i-го рядка та j-го стовпця визначає зарплату i-го співробітника у j-му місяці.
//Вивести матрицю на консоль у вигляді таблиці. Визначити загальний бюджет зарплати за рік, загальну і середню зарплату за місяць, номер якого ввести з консолі.

//7.	У генерованій матриці поміняти місцями рядки, що містять максимальний та мінімальний елементи. Якщо шукані елементи знаходяться в одному рядку, то поміняти місцями стовпчики.
//Вивести на консоль матрицю до та після переміни місцями рядків чи стовпчиків.

//8.	Знайти корені нелінійного рівняння (x^26*x)^22(x3) ^ 2 = 81, застосувавши метод Ньютона. Вивести результати на консоль.
//Здійснити перевірку правильності рішення, підставивши знайдені значення коренів в нелінійне рівняння.

//9.	Увести з консолі рядок символів (тип string). Виконати операції редагування рядка, здійснивши заміну усіх алфавітних символів на їх ASCII коди та видаливши усі цифрові символи.
//Вивести рядок після заміни на консоль.


using System;
using System.Linq;
using System.Collections.Generic;

namespace lab2
{
    class Program
    {
        static int[] array;
        static int[] simpleNumbersArray;
        static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
        static void BubbleSort(int[] arr)                //   Алгоритм сортування вставками
        {
            int temp;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        static void CreateArr(int[] arr, int min, int max)      //   Функція створення масиву випадкових чисел
        {
            Random rand = new Random();
            Console.Write("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(min, max);
                Console.Write("\t" + arr[i]);
            }
        }
        static void task1()
        {
            Console.Write("Enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            array = new int[size];
            CreateArr(array, min, max);
            Console.Write("\nSorted array: \t");
            BubbleSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t" + array[i]);
            }
            Console.WriteLine();
        }
        static void task2()
        {
            List<int> simpleNumbersList = new List<int>();

            //    Алгоритм Ератосфена
            Console.Write("\nSimple numbers: \t");

            foreach (int number in array)
            {
                bool isSimple = true;
                for (int i = 2; i < number && number != 0; i++)
                {

                    if (number % i == 0)
                    {
                        isSimple = false;
                        break;
                    }
                }
                if (isSimple)
                {
                    simpleNumbersList.Add(number);
                }
            }

            simpleNumbersList.ForEach(number =>
            {
                Console.Write(number + "\t");
            });

            simpleNumbersArray = simpleNumbersList.ToArray();

            Console.WriteLine("\n");

        }

        static void task3()
        {
            // Combining 2 arrays
            int[] combinedArray = array.Concat(simpleNumbersArray).ToArray();

            Console.Write("\nCombined array: \t");
            // Display combined array
            for (int j = 0; j < combinedArray.Length; j++)
            {
                Console.Write(combinedArray[j] + "\t");
            }

            Console.WriteLine();

            // Sum of the elements
            int sum = 0;
            for (int i = 0; i < combinedArray.Length; i++)
            {
                sum += combinedArray[i];
            }
            Console.WriteLine("Sum: " + sum);

            // Arithmetic average
            double average = (double)sum / combinedArray.Length;
            Console.WriteLine("Arithmetic average: " + average);

            // Min and max values
            int minValue = combinedArray.Min();
            int maxValue = combinedArray.Max();

            Console.WriteLine("Min value: " + minValue);
            Console.WriteLine("Max value: " + maxValue);
        }

        static void task4()
        {
            Console.Write("Enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] array4 = new int[size];
            CreateArr(array4, min, max);
            Console.Write("\nEnter element to find: ");
            int key = Int32.Parse(Console.ReadLine());
            int i;
            Console.Write($"\nElement {key} has index: ");
            for (i = 0; i < array4.Length; i++)
            {
                if (array4[i] == key)
                {
                    Console.Write(i + ", ");
                }
            }
            Console.WriteLine();
        }
        static void task5()
        {
            Console.Write("Enter the size of array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = Convert.ToInt32(Console.ReadLine());


            int[] array5 = new int[size];
            CreateArr(array5, min, max);
            Console.Write("\nEnter element to find: ");
            int key = Int32.Parse(Console.ReadLine());
            //      Реалізація алгоритму бінарного пошуку
            int begin = 0, end = size - 1;
            bool Found = false;
            int m, count = 0;

            while (begin <= end && Found == false)
            {
                m = begin + (end - begin) / 2;
                if (array5[m] == key)
                {
                    Console.WriteLine($"Your element {key} has index {m}.");
                    Found = true;
                    count++;
                }
                else if (array5[m] < key) begin = m + 1;
                else end = m - 1;
            }
            if (count == 0)
            {
                Console.WriteLine($"Your element {key} was not found.");
            }

            //int res = Array.BinarySearch(array5, Enumerable.Range(min, max));
            //Console.WriteLine(res);
        }
        static void Create_matrix(int[,] mat, int min, int max, int rows, int cols)    //   Створення матриці
        {
            Random rand = new Random();
            Console.WriteLine("\nYour matrix: ");

            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    mat[x, y] = rand.Next(min, max);
                    Console.Write("\t" + mat[x, y]);
                }
                Console.WriteLine();
            }
        }
        static void budget(int[,] mat, int rows, int cols)                //   Завдання 6(1)
        {
            int budget = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    budget += mat[i, j];
                }
            }

            Console.WriteLine("\nYear budget: " + budget);
        }
        static void salary(int[,] mat, int rows, int month)     //   Завдання 6(2)
        {
            int total = 0, average;
            for (int i = 0; i < rows; i++)
            {
                total += mat[i, month];
            }
            Console.Write($"\nTotal salary on the {month} month: {total}");
            average = total / rows;
            Console.Write($"\nAverage salary on the {month} month: {average}");
        }
        static void task6()
        {
            Console.Write("Enter the count of employees: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            int cols = 12;
            int min = 0;
            Console.Write("Enter max value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Create_matrix(matrix, min, max, rows, cols);

            Console.Write("1)Find out a year budget: ");
            budget(matrix, rows, cols);

            Console.Write("\n2)Total salary, average salary (enter the month): ");
            int month = Int32.Parse(Console.ReadLine());
            month -= 1;
            salary(matrix, rows, month);
            Console.WriteLine();
        }
        static void swap_rows(int[,] mat, int cols, int idx1, int idx2)     //    Переставляння рядків
        {
            for (int i = 0; i < cols; i++)
            {
                int temp = mat[idx1, i];
                mat[idx1, i] = mat[idx2, i];
                mat[idx2, i] = temp;
            }
        }
        static void swap_cols(int[,] mat, int rows, int idx1, int idx2)     //    Переставляння стовпців
        {
            for (int i = 0; i < rows; i++)
            {
                int temp = mat[i, idx1];
                mat[i, idx1] = mat[i, idx2];
                mat[i, idx2] = temp;
            }
        }
        static void min_max(int[,] mat, int rows, int cols)
        {
            int min = mat[0, 0];
            int max = mat[0, 0];
            int x1 = 0, x2 = 0;
            int y1 = 0, y2 = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                        x1 = i;
                        y1 = j;
                    }
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                        x2 = i;
                        y2 = j;
                    }
                }
            }
            if (x1 != x2) { swap_rows(mat, cols, x1, x2); }
            else if (x1 == x2) { swap_cols(mat, rows, y1, y2); }
        }
        static void task7()
        {
            Console.Write("Enter the count of rows: ");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the count of columns: ");
            int cols = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter min value: ");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter max value: ");
            int max = Convert.ToInt32(Console.ReadLine());

            int[,] matrix2 = new int[rows, cols];
            Create_matrix(matrix2, min, max, rows, cols);

            min_max(matrix2, rows, cols);
            Console.WriteLine("Matrix with sorted rows:");
            for (int x = 0; x < rows; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    Console.Write("\t" + matrix2[x, y]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static double func(double new_x)
        {
            return Math.Pow(Math.Pow(new_x, 2) - 6 * new_x, 2) - 2 * Math.Pow(new_x - 3, 2) - 81;
        }
        static double Dfunc(double new_x)           //   похідна
        {
            return -4 * new_x + (4 * new_x - 12) * (Math.Pow(new_x, 2) - 6 * new_x) + 12;
        }
        static double Dfunc2(double new_x)           //   похідна 2го порядку
        {
            return 4 * (Math.Pow(new_x, 2) - 6 * new_x + 2 * Math.Pow(new_x - 3, 2) - 1);
        }

        static double newton_method(double a, double b, double precision)
        {
            double xp, xt;
            if (func(a) * Dfunc2(a) > 0) { xt = a; }     // якщо добуток функції та похідної більше нуля при A, то початок циклу - А
            else { xt = b; }                        // в іншому випадку - В
            do
            {
                xp = xt;
                xt = xp - func(xp) / Dfunc(xp);         // формула
            } while (Math.Abs(xt - xp) > precision);   // цикл викончується доки різниця двох останніх коренів не досягне точності
            return xt;
        }
        static void check_root(double root)             //   Перевірка достовірності
        {
            double check = 2 * Math.Pow(root, 4) - Math.Pow(root, 3) - 9 * Math.Pow(root, 2) + 13 * root - 5;
            if (check < 2 && check > -2)
            {
                Console.WriteLine("Fine! Y = " + check + ". That is right root.");
            }
            else
            {
                Console.WriteLine("Wrong interval");
            }
        }
        static void task8()
        {
            Console.Write("Enter precision: ");
            double prs = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter first point: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter second point: ");
            double b = Convert.ToDouble(Console.ReadLine());

            double x = newton_method(a, b, prs);
            Console.WriteLine("\nX = " + x);
            check_root(x);
        }

        static void task9()
        {
            Console.Write("\nEnter string: ");
            string str = Console.ReadLine();

            // Result string
            string resultStr = "";

            for (int i = 0; i < str.Length; i++)
            {
                // Check if symbol is letter
                if (char.IsLetter(str[i]))
                {
                    resultStr += (int)str[i] + " ";
                }
            }

            Console.WriteLine("Result string: " + resultStr + "\n");
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Lab-2, var-2");
            Console.WriteLine("Developer: Byvalkevych Anastasia Victorivna, gr - 13\n");
            Menu();
        }

        static void Menu()
        {
            int command;
            Console.WriteLine("                               MENU");
            Console.WriteLine("1. Generate and sort elements of a one-dimensional array.");
            Console.WriteLine("2. One-dimensional array of prime numbers (Eratosthenes algorithm).");
            Console.WriteLine("3. Combine arrays and make calculations with elements.");
            Console.WriteLine("4. Linear search method.");
            Console.WriteLine("5. Binary search method.");
            Console.WriteLine("6. Generate a matrix and make the appropriate calculations.");
            Console.WriteLine("7. Swap rows or columns");
            Console.WriteLine("8. ( x^1 - 6x )^2 - 2 ( x - 3 )^2 = 81 ( Newton's method )");
            Console.WriteLine("9. Line editing operations");
            Console.WriteLine("10.Exit");
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            do
            {
                Console.WriteLine("------------------------------------------------------------------");
                Console.Write("Select command to execute: ");
                command = Convert.ToInt32(Console.ReadLine());
                switch (command)
                {
                    case 1: task1(); break;
                    case 2: task2(); break;
                    case 3: task3(); break;
                    case 4: task4(); break;
                    case 5: task5(); break;
                    case 6: task6(); break;
                    case 7: task7(); break;
                    case 8: task8(); break;
                    case 9: task9(); break;
                    default: Console.WriteLine("Unknown command - repeat again"); break;
                }
            } while (command != 10);
        }
    }
}

