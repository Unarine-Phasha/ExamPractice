using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    internal abstract class Student
    {
        int studentId;
        string studentName;
        string studentSurname;
        int studentAge;
        string courseName;
        double studentGPA;

        protected Student(int studentId, string studentName, string studentSurname, int studentAge, string courseName, double studentGPA)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.studentSurname = studentSurname;
            this.studentAge = studentAge;
            this.courseName = courseName;
            this.studentGPA = studentGPA;
        }

        public int StudentId { get => studentId; set => studentId = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public string StudentSurname { get => studentSurname; set => studentSurname = value; }
        public int StudentAge { get => studentAge; set => studentAge = value; }
        public string CourseName { get => courseName; set => courseName = value; }
        public double StudentGPA { get => studentGPA; set => studentGPA = value; }

        public abstract void DisplayInfo();
    }
}
