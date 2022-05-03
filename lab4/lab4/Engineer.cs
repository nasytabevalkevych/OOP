using System;

namespace lab4
{
    class Engineer : Person
    {
        private string _Achievs;
        private string _Skills;
        private string _Quality;

        //          Конструктори
        public Engineer()
        {

        }
        public Engineer(string Name, string Position, int Age, int Experience, int Salary,
            string Achievs, string Skills, string Quality) : base(Name, Position, Age, Experience, Salary)
        {
            _Achievs = Achievs;
            _Skills = Skills;
            _Quality = Quality;
        }
        //          Аксесори
        public string Achievs { get; set; }
        public string Skills { get; set; }
        public string Quality { get; set; }
        //          Ввід даних
        public void Enter()
        {
            base.Enter();
            Console.Write("\tВведіть трудові досягнення: ");
            _Achievs = Console.ReadLine();
            Console.Write("\tВведіть професійні навички:  ");
            _Skills = Console.ReadLine();
            Console.Write("\tВведіть особисті якості: ");
            _Quality = Console.ReadLine();
        }
        //          Вивід
        public void Show()
        {
            base.Show();
            Console.WriteLine($"Трудові досягнення інженера: {_Achievs}\nПрофесійні навички інженера: {_Skills}\n" +
                              $"Особисті якості інженера: {_Quality}");
        }
        //          Творча проектна робота
        public void ProfSkills()
        {
            Random rand = new Random();
            int projects = rand.Next(1, 4);
            int value = 0;
            Console.Write("Введіть досвід роботи інженера: ");
            Experience = Int32.Parse(Console.ReadLine());

            switch (projects)
            {
                case 1:
                    Console.WriteLine("\nІнженер розробив мало проектів. ");
                    value = 10; break;
                case 2:
                    Console.WriteLine("\nІнженер розробив достатньо проектів. ");
                    value = 15; break;
                case 3:
                    Console.WriteLine("\nІнженер розробив багато проектів. ");
                    value = 20; break;
                case 4:
                    Console.WriteLine("\nІнженер розробив більше всіх проектів. ");
                    value = 25; break;
            }

            if (Experience < 3)
            {
                Console.WriteLine("У інженера малий досвід роботи.");
                if (value == 10)
                {
                    Console.WriteLine("Інженеру потрібно працювати краще, щоб заявити про себе.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Інженер виконує достатьньо проектів.");
                }
                if (value == 20)
                {
                    Console.WriteLine("У інженера добре виходить, він виконує багато проектів.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Інженер має хороші перспективи, його потрібно підвищити.");
                }
            }
            else if (Experience >= 3 && Experience <= 5)
            {
                Console.WriteLine("У інженера середній досвід роботи.");
                if (value == 10)
                {
                    Console.WriteLine("Інженеру потрібно працювати краще, він відстає.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Інженер виконує середню кількість проектів.");
                }
                if (value == 20)
                {
                    Console.WriteLine("Інженер гарно працює, виконано багато проектів.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Інженер дуже добре проявляє свої творчі якості.");
                }
            }
            else if (Experience > 5 && Experience <= 10)
            {
                Console.WriteLine("У інженера достатній досвід роботи.");
                if (value == 10)
                {
                    Console.WriteLine("Інженер погано працює, йому потрібно працювати набагато краще.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Інженер виконує недостатьньо проектів для його досвіду.");
                }
                if (value == 20)
                {
                    Console.WriteLine("Інженер виконує звичайну кількість проектів для його досвіду.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Інженер демонструє лідерські навички.");
                }
            }
            else if (Experience > 10)
            {
                Console.WriteLine("У інженера високий досвід роботи.");
                if (value == 10)
                {
                    Console.WriteLine("Інженер сильно відстав. Для його досвіду виконано дуже мало проектів.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Інженер виконує незначну кількість проектів для його досвіду.");
                }
                if (value == 20)
                {
                    Console.WriteLine("Інженер добре працює, але може працювати ще краще.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Інженер проявляє себе як лідер, з нього беруть приклад.");
                }
            }
            else if (Experience < 0)
            {
                Console.WriteLine("Невірно введені дані...");
            }
        }
    }
}