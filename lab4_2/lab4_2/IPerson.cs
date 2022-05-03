using System;

namespace lab4_2
{
    interface IPerson
    {
        void Enter();
        void Show();
        void ProfSkills();
    }

    class Person : IPerson
    {
        private string _Name;
        private string _Position;
        private int _Age;
        private int _Experience;
        private int _Salary;
        //          Конструктори
        public Person()
        {

        }
        public Person(string Name, string Position, int Age, int Experience, int Salary)
        {
            _Name = Name;
            _Position = Position;
            _Age = Age;
            _Experience = Experience;
            _Salary = Salary;
        }
        //          Аксесори
        public string Name { get; set; }
        public string Position { get; set; }
        public int Age { get; set; }
        public int Experience { get; set; }
        public int Salary { get; set; }
        //          Ввід даних
        public virtual void Enter()
        {
            Console.Write("\tВведіть ім'я: ");
            _Name = Console.ReadLine();
            Console.Write("\tВведіть посаду: ");
            _Position = Console.ReadLine();
            Console.Write("\tВведіть вік: ");
            _Age = Int32.Parse(Console.ReadLine());
            Console.Write("\tВведіть досвід роботи у роках: ");
            _Experience = Int32.Parse(Console.ReadLine());
            Console.Write("\tВведіть зарплату: ");
            _Salary = Int32.Parse(Console.ReadLine());
            Console.WriteLine();
        }
        //          Вивід даних
        public virtual void Show()
        {
            Console.WriteLine($"Ім'я: {_Name}\nПосада: {_Position}\nВік: {_Age}" +
                              $"\nДосвід: {_Experience} роки\nЗарплата: {_Salary}");
        }
        //
        public virtual void ProfSkills()
        {

        }
    }
}