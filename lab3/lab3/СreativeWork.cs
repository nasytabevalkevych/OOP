using System;


namespace lab3
{
    class СreativeWork
    {
        static int[] array;
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
        public void Task1()
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
        public void Task2()
        {
            Console.Write("Enter string: ");
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
    }
}
