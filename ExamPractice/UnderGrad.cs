using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    internal class UnderGrad: Student
    {
        public UnderGrad(int studentId, string studentName, string studentSurname, int studentAge, string courseName, double studentGPA) : base(studentId, studentName, studentSurname, studentAge, courseName, studentGPA)
        {
        }

       public override void DisplayInfo()
        {
            Console.WriteLine("=====Undergraduate Student Information=====");
            Console.WriteLine($"Student ID: {StudentId}");
            Console.WriteLine($"Student Name: {StudentName}");
            Console.WriteLine($"Student Surname: {StudentSurname}");
            Console.WriteLine($"Student Age: {StudentAge}");
            Console.WriteLine($"Course Name: {CourseName}");
            Console.WriteLine($"Student GPA: {StudentGPA}");
        }
    }
}
