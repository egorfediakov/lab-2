using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee("Иванов", "Иван", "директор", 7));
            employees.Add(new Employee("Павленко", "Павел", "директор", 11));
            employees.Add(new Employee("Сорокин", "Коля", "продавец", 2));
            employees.Add(new Employee("Васильев", "Вася", "менеджер", 5));

            foreach (Employee item in employees)
            {
                item.Info();
            }
            Console.ReadKey();
        }
    }
    class Employee
    {
        public string SurName { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Experience { get; set; }
        public Employee(string surname, string name, string position, int exp)
        {
            this.SurName = surname;
            this.Name = name;
            this.Position = position;
            this.Experience = exp;
        }

        public void SalaryMeth()
        {
            int salary = 0;
            if (Experience >= 7 && Position == "директор")
            {
                salary = salary + 12000;

            }
            else if (Experience == 5 && Position == "менеджер")
            {
                salary = salary + 9000;
            }
            else if (Experience < 5 && Position == "продавец")
            {
                salary = salary + 4000;
            }
            else
            {
                salary = 0;
            }
            Console.WriteLine($"Оклад - {salary}");


        }

        public void TaxLevy(double rPrice)
        {
            double result;
            result = rPrice * 105;
            Console.WriteLine($"Налоговый сбор - {result}");
        }
        public void Info()
        {
            Console.WriteLine($"Фамилия - {SurName}, Имя - {Name}, Позиция - {Position}, Стаж - {Experience}");
            SalaryMeth();
            Console.WriteLine("Введите значение цены: ");
            double rPrice = Convert.ToDouble(Console.ReadLine());
            TaxLevy(rPrice);

            Console.WriteLine();
        }

    }
}
