using System;

namespace lab4_4
{
    class Person
    {
        private string _Name;
        //          Конструктори
        public Person()
        {

        }
        public Person(string Name)
        {
            _Name = Name;
        }
        //          Аксесори
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }
        //          Ввід даних
        public void Enter()
        {
            Console.Write("\tВведіть ім'я робітника: ");
            _Name = Console.ReadLine();
        }
        //          Вивід даних
        public void Show()
        {
            Console.WriteLine($"\nІм'я робітника: {_Name}");
        }
    }
}