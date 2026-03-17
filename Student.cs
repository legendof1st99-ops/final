using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace final
{
    public class Student : Person
    {
        private string studentId;
        private double score;

        public string StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public double Score
        {
            get { return score; }
            set { score = value; }
        }

        public Student(string name, string id, double score) : base(name)
        {
            StudentId = id;
            Score = score;
        }

        public string CalculateGrade()
        {
            if (Score >= 80) return "A";
            else if (Score >= 75) return "B+";
            else if (Score >= 70) return "B";
            else if (Score >= 65) return "C+";
            else if (Score >= 60) return "C";
            else if (Score >= 55) return "D+";
            else if (Score >= 50) return "D";
            else return "F";
        }

        public override string GetInfo()
        {
            return $"{StudentId} {FullName} Score:{Score} Grade:{CalculateGrade()}";
        }
    }
}
