using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace final
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter Course Code: ");
            string code = Console.ReadLine();

            Console.Write("Enter Course Name: ");
            string name = Console.ReadLine();

            Course course = new Course(code, name);

            while (true)
            {
                Console.WriteLine("\n===== MENU =====");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Show Students");
                Console.WriteLine("3. Show Statistics");
                Console.WriteLine("4. Exit");

                Console.Write("Choose: ");
                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    Console.Write("Student Name: ");
                    string n = Console.ReadLine();

                    Console.Write("Student ID: ");
                    string id = Console.ReadLine();

                    Console.Write("Score: ");
                    double score = Convert.ToDouble(Console.ReadLine());

                    Student student = new Student(n, id, score);

                    course.AddStudent(student);
                }
                else if (choice == "2")
                {
                    course.ShowStudents();
                }
                else if (choice == "3")
                {
                    course.ShowStatistics();
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Program End.");
                    break;
                }
            }
        }
    }
}