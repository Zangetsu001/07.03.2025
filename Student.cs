using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Student:Person
    {
        private DateTime dateofbirth;
        int course;
        public DateTime DateOfBirth
        {
            get
            {
                return dateofbirth;
            }
            set
            {
                dateofbirth = value;
            }
        }
        public int Course
        {
            get
            {
                return course;
            }
            set
            {
                course = value;
            }
        }
        public Student(string Name, string Surname, int Age, DateTime dateOfBirth, int course)
            : base(Name, Surname, Age)  
        {
            DateOfBirth = dateOfBirth;
            Course = course;
        }
        public void DisplayStudentInfo()
        {
            Console.WriteLine($"Инициалы: {Name} {Surname}, Возраст: {Age}, Дата рождения: {DateOfBirth.ToShortDateString()}, Курс: {Course}");
        }
    }
}
