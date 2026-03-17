using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final
{
    public class Course
    {
        private string courseCode;
        private string courseName;

        private List<Student> students;

        public Course(string code, string name)
        {
            courseCode = code;
            courseName = name;
            students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void ShowStudents()
        {
            Console.WriteLine("\nStudent List");

            foreach (Student s in students)
            {
                Console.WriteLine(s.GetInfo());
            }
        }

        public void ShowStatistics()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No student data.");
                return;
            }

            double max = students.Max(s => s.Score);
            double min = students.Min(s => s.Score);
            double avg = students.Average(s => s.Score);

            Console.WriteLine("\nStatistics");
            Console.WriteLine("Highest Score : " + max);
            Console.WriteLine("Lowest Score  : " + min);
            Console.WriteLine("Average Score : " + avg.ToString("F2"));
        }
    }
}