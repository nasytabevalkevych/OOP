using System;

namespace lab4
{
    class Employee : Person
    {
        private string _Achievs;
        private string _Skills;
        private string _Quality;

        //          Конструктори
        public Employee()
        {

        }
        public Employee(string Name, string Position, int Age, int Experience, int Salary,
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
            Console.WriteLine($"Трудові досягнення робітника: {_Achievs}\nПрофесійні навички робітника: {_Skills}\n" +
                              $"Особисті якості робітника: {_Quality}");
        }
        //          Технічна наладка обладнання
        public void ProfSkills()
        {
            Random rand = new Random();
            int projects = rand.Next(1, 4);
            int value = 0;
            Console.Write("Введіть досвід роботи робітника: ");
            Experience = Int32.Parse(Console.ReadLine());

            switch (projects)
            {
                case 1:
                    Console.WriteLine("\nРобітник погано ремонтує обланання. ");
                    value = 10; break;
                case 2:
                    Console.WriteLine("\nРобітник не виділяється серед інших у наладці обладнання. ");
                    value = 15; break;
                case 3:
                    Console.WriteLine("\nРобітник має гарні навички наладки обладнання. ");
                    value = 20; break;
                case 4:
                    Console.WriteLine("\nРобітник дуже добре ремонтує обладнання. ");
                    value = 25; break;
            }

            if (Experience < 3)
            {
                Console.WriteLine("Робітник має малий досвід наладки.");
                if (value == 10)
                {
                    Console.WriteLine("Робітнику потрібно ще багато вчитись. У нього все попереду.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Робітник має старатись краще ремонтувати обладнання.");
                }
                if (value == 20)
                {
                    Console.WriteLine("У робітника добре виходить, він добре ремонтує обладнання.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Робітник має хороші перспективи. Він чудово ремонтує.");
                }
            }
            else if (Experience >= 3 && Experience <= 5)
            {
                Console.WriteLine("Робітника має середній досвід наладки.");
                if (value == 10)
                {
                    Console.WriteLine("Робітник повинен ремонтувати краще з його досвідом роботи.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Робітник ремонтує прийнятно.");
                }
                if (value == 20)
                {
                    Console.WriteLine("Робітник гарно ремонтує. Він має певні успіхи.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Робітник дуже добре проявляє свої якості наладки.");
                }
            }
            else if (Experience > 5 && Experience <= 10)
            {
                Console.WriteLine("Робітник має достатній досвід наладки.");
                if (value == 10)
                {
                    Console.WriteLine("Робітник погано ремонтує, йому потрібно ремонтувати набагато краще.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Робітник не проявляє гарних вмінь з його досвідом..");
                }
                if (value == 20)
                {
                    Console.WriteLine("Робітником задоволені багато клієнтів.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Робітник демонструє свої якості наладки найкращим чином.");
                }
            }
            else if (Experience > 10)
            {
                Console.WriteLine("Робітник має високий досвід наладки.");
                if (value == 10)
                {
                    Console.WriteLine("Робітник жахливо ремонтує. До нього ніхто не звертається.");
                }
                else if (value == 15)
                {
                    Console.WriteLine("Робітник демонструє свої мінімальні вміння. ");
                }
                if (value == 20)
                {
                    Console.WriteLine("Робітник гарно ремонтує, але може ремонтувати ще краще.");
                }
                if (value == 25)
                {
                    Console.WriteLine("Робітник є дуже популярним серед інших, має чудовий досвід та хороші навички.");
                }
            }
            else if (Experience < 0)
            {
                Console.WriteLine("Невірно введені дані...");
            }
        }
    }
}