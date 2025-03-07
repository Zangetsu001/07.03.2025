using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", "Doe", 30);
            person.Output();
            Console.WriteLine();
            Employee employee = new Employee("Jane", "Smith", 28, "TechCorp", "Developer");
            employee.Output();
            Console.WriteLine($"\n");
            Person employeeAsPerson = new Employee("Alice", "Johnson", 35, "Innovate Ltd", "Manager");
            employeeAsPerson.Output();

            Student[] students = new Student[3];
            students[0] = new Student("Я", "Моя", 20, new DateTime(2004, 5, 15), 2);
            students[1] = new Student("Дима", "Вчина", 22, new DateTime(2002, 11, 20), 3);
            students[2] = new Student("Антон", "ловыраолшр", 19, new DateTime(2005, 3, 12), 1);

            Console.WriteLine("Информация о студентах:");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("| Имя            | Возраст | Дата рождения | Курс |");
            Console.WriteLine("---------------------------------------------------");
            foreach (var student in students)
            {
                Console.WriteLine($"| {student.Name} {student.Surname,-13} | {student.Age,-3} | {student.DateOfBirth.ToShortDateString(),-13} | {student.Course,-6} |");
            }
            Console.WriteLine("---------------------------------------------------");
            

            
            Console.Read();
        }
    }
}
