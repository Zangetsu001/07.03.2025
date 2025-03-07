using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Employee : Person
    {
        string companyname;
        string position;
        public string CompanyName
        {
            get
            {
                return companyname;
            }
            set
            {
                companyname = value;
            }
        }
        public string Position
        {
            get
            {
                return position;
            }
            set
            {
                position = value;
            }
        }

        public Employee() { }
        public Employee (string name, string surname, int age, string companyname, string position):base(name, surname, age)
        {
            this.CompanyName = companyname;
            this.Position = position;
        }
        new public void Output()
        {
            Console.Write($"Имя: {Name}\nФамилия: {Surname}\nВозраст: {Age}\nНазвание компании: {CompanyName}\nДолжность: {Position}");
        }
    }
}

