using System;
using System.IO;



//2.Визначити в класах закриті поля:
//	клас Department: назва кафедри, кількість викладачів, кількість студентів, назва освітньої програми, за якою навчаються студенти (наприклад «Інженерія програмного забезпечення»),
//оцінка з акредитації освітньої програми (A, B, E);

namespace lab3
{
    public class Department
    {
        private string _NameDepartment;
        private int _NumTeachers;
        private int _NumStudents;
        private string _NameProgram;
        private string _MarkAccreditation;
        public double newstudent;
        public string to;
        private object writeDepartment;

        public Department()
        {
            _NameDepartment = "";
            _NumTeachers = 0;
            _NumStudents = 0;
            _NameProgram = "";
            _MarkAccreditation = "";
        }

        public Department(string NameDepartment, int NumTeachers, int NumStudents, string NameProgram, string MarkAccreditation)
        {
            _NameDepartment = NameDepartment;
            _NumTeachers = NumTeachers;
            _NumStudents = NumStudents;
            _NameProgram = NameProgram;
            _MarkAccreditation = MarkAccreditation;
        }
        public string nameDepartment { get { return _NameDepartment; } set { _NameDepartment = value; } }
        public int numTeachers { get { return _NumTeachers; } set { _NumTeachers = value; } }
        public int numStudents { get { return _NumStudents; } set { _NumStudents = value; } }
        public string nameProgram { get { return _NameProgram; } set { _NameProgram = value; } }
        public string markAccreditation { get { return _MarkAccreditation; } set { _MarkAccreditation = value; } }



        public void EnterValues()
        {
            Console.Write("Department name: ");
            _NameDepartment = Console.ReadLine();
            while (nameDepartment == null)
            {
                Console.Write("Wrong! Department name has to include symbols.\nDepartment name: ");
                _NameDepartment = Console.ReadLine();
            }
            Console.Write("Number of teachers: ");
            while (!int.TryParse(Console.ReadLine(), out _NumTeachers)) //перевірка на правильність вводу
            {
                Console.Write("Wrong! Number of teachers: ");
            }
            Console.Write("Number of students: ");
            while (!int.TryParse(Console.ReadLine(), out _NumStudents)) //перевірка на правильність вводу
            {

                Console.Write("Wrong! Number of students: ");
            }
            Console.Write("The name of the educational program: ");
            _NameProgram = Console.ReadLine();
            while (_NameProgram == null)
            {
                Console.Write("Wrong! Educational program name has to include symbols.\nEducational program name: ");
                _NameProgram = Console.ReadLine();
            }
            Console.Write("Evaluation of the accreditation (A, B, E): ");
            _MarkAccreditation = Console.ReadLine();
            while (markAccreditation == null)
            {
                Console.Write("Wrong!\nEvaluation of the accreditation (A, B, E): ");
                _NameProgram = Console.ReadLine();
            }
        }


        public void NumStd()
        {
            switch (_MarkAccreditation)
            {

                case "A":
                    Console.WriteLine("Increase in the number of students by 20%");
                    newstudent = _NumStudents / 0.2;
                    Console.WriteLine("Changed number of students:" + newstudent);
                    break;

                case "B":
                    Console.WriteLine("The number of students does not change");
                    newstudent = _NumStudents;
                    Console.WriteLine("Number of students:" + newstudent);
                    break;

                case "E":
                    Console.WriteLine("The number of students decreases by 10%");
                    newstudent = _NumStudents * 0.1;
                    Console.WriteLine("Changed number of students:" + newstudent);
                    break;
                default:
                    Console.WriteLine("Nothing");
                    break;
            }
        }
        public void OutputValues()
        {
             Console.WriteLine("Department name: " + nameDepartment);
             Console.WriteLine("Number of teachers: " + numTeachers);
             Console.WriteLine("Number of students: " + numStudents);
             Console.WriteLine("The name of the educational program: " + nameProgram);
             Console.WriteLine("Evaluation of the accreditation (A, B, E): " + markAccreditation);
             Console.WriteLine("Changed number of students: " + newstudent);
        }
        public void WriteToTXT()
        {
            StreamWriter writeDepartment = new StreamWriter(@"D:\my\c#\Lab3\Department_data.txt");
            writeDepartment.WriteLine("------------------------------------------\n" +
                                   "Department name: " + nameDepartment + "\n" +
                                   "The name of the educational program: " + nameProgram + "\n" +
                                   "Number of teachers: " + numTeachers + "\n" +
                                   "Number of students: " + numStudents + "\n" +
                                   "Evaluation of the accreditation (A, B, E): " + markAccreditation + "\n");
            writeDepartment.Close();
        }
        
        public void ChangeNumberOf1()
        {
            Random rand = new Random();
            Console.WriteLine($"Department name: {nameDepartment}\n" +
                              $"The name of the educational program: {nameProgram}\n" +
                              $"Number of teachers: {numTeachers}\n" +
                              $"Number of students: {numStudents}\n"+
                               $"Evaluation of the accreditation (A, B, E): {markAccreditation}");
        }
    }

    
}
