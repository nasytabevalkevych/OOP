﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;

namespace lab4_4
{
    class Employee : Person, IComparable, IComparer<Employee>, IEnumerable
    {
        private int _Age;
        private int _Salary;
        //          Конструктори
        public Employee()
        {

        }
        public Employee(string Name, int Age, int Salary)
            : base(Name)
        {
            _Age = Age;
            _Salary = Salary;
        }
        //          Аксесори
        public int Age
        {
            get { return _Age; }
            set { _Age = value; }
        }
        public int Salary
        {
            get { return _Salary; }
            set { _Salary = value; }
        }
        //          Ввід даних
        public void Enter()
        {
            base.Enter();
            Console.Write("\tВведіть вік робітника: ");
            _Age = Int32.Parse(Console.ReadLine());
            Console.Write("\tВведіть зарплату робітника: ");
            _Salary = Int32.Parse(Console.ReadLine());
        }
        //          Вивід
        public void Show()
        {
            base.Show();
            Console.WriteLine($"Вік робітника: {_Age} років\nЗарплата: {_Salary} гривень\n");
        }
        //          Інтерфейс IComparable
        public int CompareTo(object obj)
        {
            Employee employee = obj as Employee;

            if (employee != null)
            {
                if (this.Age > employee.Age)
                {
                    Console.Write($"{this.Name} старший за {employee.Name} ({this.Age} > {employee.Age}) \nРезультат: ");
                    return -1;
                }
                else if (this.Age < employee.Age)
                {
                    Console.Write($"{this.Name} молодший за {employee.Name} ({this.Age} < {employee.Age}) \nРезультат: ");
                    return 1;
                }
                else
                {
                    Console.Write($"{this.Name} за віком такий самий як {employee.Name} ({this.Age} = {employee.Age}) \nРезультат: ");
                    return 0;
                }
            }
            else
            {
                throw new Exception("Помилка...");
            }

        }

        private void CompAge(Employee employee1, Employee employee2)
        {
            if (employee1.Age > employee2.Age)
            {
                Console.WriteLine($"{employee1.Name} старший за {employee2.Name} ({employee1.Age} > {employee2.Age})");
            }
            else if (employee1.Age < employee2.Age)
            {
                Console.WriteLine($"{employee1.Name} молодший за {employee2.Name} ({employee1.Age} < {employee2.Age})");
            }
            else
            {
                Console.WriteLine($"{employee1.Name} за віком такий самий як {employee2.Name} ({employee1.Age} = {employee2.Age})");
            }
        }
        //          Інтерфейс IComparer
        public int Compare(Employee employee1, Employee employee2)
        {
            CompAge(employee1, employee2);
            if (employee1.Salary > employee2.Salary)
            {
                Console.Write($"{employee1.Name} має більшу зарплату ніж {employee2.Name} ({employee1.Salary} > {employee2.Salary}) \nРезультат: ");
                return -1;
            }
            else if (employee1.Salary < employee2.Salary)
            {
                Console.Write($"{employee1.Name} має меншу зарплату ніж {employee2.Name} ({employee1.Salary} < {employee2.Salary}) \nРезультат: ");
                return 1;
            }
            else
            {
                Console.Write($"{employee1.Name} має таку саму зарплату як {employee2.Name} ({employee1.Salary} = {employee2.Salary}) \nРезультат: ");
                return 0;
            }
        }
        //          Інтерфейс IEnumerable
        public class Employees : IEnumerable
        {
            private Employee[] _employees;
            private int _position = -1;

            public Employees(Employee[] employees)
            {
                _employees = new Employee[employees.Length];
                for (int i = 0; i < employees.Length; i++)
                {
                    _employees[i] = employees[i];
                }
            }
            IEnumerator IEnumerable.GetEnumerator()
            {
                return (IEnumerator)GetEnumerator();
            }
            public EmployeeEnumerator GetEnumerator()
            {
                return new EmployeeEnumerator(_employees);
            }
        }

        public class EmployeeEnumerator : IEnumerator
        {
            public Employee[] _employees;
            int position = -1;

            public EmployeeEnumerator(Employee[] list)
            {
                _employees = list;
            }
            public bool MoveNext()
            {
                position++;
                return (position < _employees.Length);
            }
            public void Reset()
            {
                position = -1;
            }

            object IEnumerator.Current
            {
                get
                {
                    return Current;
                }
            }
            public Employee Current
            {
                get
                {
                    try
                    {
                        return _employees[position];
                    }
                    catch (IndexOutOfRangeException)
                    {
                        throw new InvalidOperationException();
                    }
                }
            }
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}