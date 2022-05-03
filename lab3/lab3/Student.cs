using System;
using System.IO;



//	клас Student: FirstName, LastName, назва освітньої програми, рік навчання (курс), Rating, 
namespace lab3
{
    public class Student
    {
        private string _FirstName;
        private string _LastName;
        private string _NameProgram;
        private int _Course;
        private int _Rating;
        public static int[] arr = new int[0];
        public Student()
        {
            _FirstName = "";
            _LastName = "";
            _NameProgram = "";
            _Course = 0;
        }
        public Student(string FirstName, string LastName, string EducProgram, int Rating, int Course)
        {
            _FirstName = FirstName;
            _LastName = LastName;
            _NameProgram = EducProgram;
            _Rating = Rating;
            _Course = Course;
        }
        public string firstName { get { return _FirstName; } set { _FirstName = value; } }
        public string lastName { get { return _LastName; } set { _LastName = value; } }
        public string nameProgram { get { return _NameProgram; } set { _NameProgram = value; } }
        public int course { get { return _Course; } set { _Course = value; } }
        //public int rating { get { return _Rating; } set { _Rating = value; } }
        public void CreatingArray()
        {
            ushort size;
            Console.Write("Estimates are needed to determine the rating\n");
            Console.Write("Number of estimates: ");
            while (!UInt16.TryParse(Console.ReadLine(), out size)) //перевірка на правильність вводу
            {
                Console.Write("Wrong!Number of estimates: ");
            }
            Array.Resize(ref arr, size);

            Random arrRand = new Random();
            for (int i = 0; i < size; i++)
            {
                arr[i] = arrRand.Next(1, 10);
            }
        }
        public void OutputArray()
        {
            Console.Write("Your marks:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
            Console.WriteLine();
        }
        public void Suma()
        {
            _Rating = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                _Rating += arr[i];
            }
            Console.WriteLine("Rating: " + _Rating);
        }

        public void EnterValues()
        {
            Console.Write("FirstName: ");
            _FirstName = Console.ReadLine();
            while (_FirstName == null)
            {
                Console.Write("Wrong! FirstName has to include symbols.\nFirstName: ");
                _FirstName = Console.ReadLine();
            }
            Console.Write("LastName: ");
            _LastName = Console.ReadLine();
            while (_LastName == null)
            {
                Console.Write("Wrong! LastName has to include symbols.\nLastName: ");
                _LastName = Console.ReadLine();
            }
            Console.Write("The name of the educational program: ");
            _NameProgram = Console.ReadLine();
            while (_NameProgram == null)
            {
                Console.Write("Wrong! Educational program name has to include symbols.\nEducational program name: ");
                _NameProgram = Console.ReadLine();
            }
            Console.Write("Course: ");
            while (!int.TryParse(Console.ReadLine(), out _Course)) //перевірка на правильність вводу
            {
                Console.Write("Wrong! Course: ");
            }

        }
        public void OutputValues()
        {
            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LastName: " + lastName);
            Console.WriteLine("The name of the educational program: " + nameProgram);
            Console.WriteLine("Course: " + course);
            Console.WriteLine("Rating: " + _Rating);

        }
        public void WriteToTXT()
        {
            StreamWriter writeStudent = new StreamWriter(@"D:\my\c#\Lab3\Student_data.txt");
            writeStudent.WriteLine("------------------------------------------\n" +
                                   "FirstName: " + firstName + "\n" +
                                   "LastName: " + lastName + "\n" +
                                   "The name of the educational program: " + nameProgram + "\n" +
                                   "Rating: " + _Rating + "\n");
            writeStudent.Close();
        }
        public void ChangeNumberOf()
        {
            Random rand = new Random();
            Console.WriteLine($"FirstName: {firstName}\n" +
                              $"LastName: {lastName}\n" +
                              $"The name of the educational program: {nameProgram}\n" +
                              $"Rating: {_Rating}");
        }

        public partial class ContestWork
        {
            public string _NameCompetition;
            public string _NameWork;
            public int _ApprobationWork;

            public void Compliance()
            {
                Console.Write("Title of your competitive work: ");
                _NameWork = Console.ReadLine();
                while (_NameWork == null)
                {
                    Console.Write("Wrong! Title of competitive work: ");
                    _NameWork = Console.ReadLine();
                }
                Console.WriteLine("\nIn the process of development...\n");
            }
        }
        public partial class ContestWork
        { 
            public void QualityWork()
            {
                Console.WriteLine("You can see the scores for your work \n");
                int _ApprobationWork = 0;//n   an=a(n-1)+d
                int a2 = 2;
                int d = 2;
                int sum = 0;
                Console.Write("Approbation of work (number of articles): ");
                while (!int.TryParse(Console.ReadLine(), out _ApprobationWork)) //перевірка на правильність вводу
                {
                    Console.Write("Wrong! Approbation of work (number of articles): ");
                }
                if(_ApprobationWork<=0||_ApprobationWork>=6)
                {
                    Console.Write("Wrong! You have 0 or more than 5 approbation of work");
                }
                else
                    for (int i = 0; i < _ApprobationWork; i++)
                    {
                        sum = a2 * (_ApprobationWork - 1) + d;
                    }
                        
                Console.WriteLine("The Quality of Work(mark) = " + sum);
            }
        }
    }
}
