using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    internal class StudentManager
    {
        private List<Student> students = new List<Student>();
        public void RegisterStudent()
        {
            Console.WriteLine("=====Register a Student=====");
            Console.WriteLine("1. Register Undergraduate Student");
            Console.WriteLine("2. Register Postgraduate Student");
            Console.WriteLine("============================");
            Console.Write("Select an option from above(1-2):");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    RegisterUnderGrad();
                    break;
                case "2":
                    RegisterPostGrad();
                    break;
                default:
                    Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                    break;
            }
        }
        public void RegisterUnderGrad()
        {
            Console.Clear();
            UnderGrad underGrad = new UnderGrad(0, "", "", 0, "", 0.0);
            Console.WriteLine("=====Register Undergraduate Student=====");
            Console.Write("Enter Student ID: ");
            underGrad.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            underGrad.StudentName = Console.ReadLine();
            Console.Write("Enter Student Surname: ");
            underGrad.StudentSurname = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            underGrad.StudentAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            underGrad.CourseName = Console.ReadLine();
            Console.Write("Enter Student GPA: ");
            underGrad.StudentGPA = double.Parse(Console.ReadLine());
            students.Add(underGrad);
            Console.WriteLine("Student has been registered successfully.");
        }
        public void RegisterPostGrad()
        {
            Console.Clear();
            PostGrad postGrad = new PostGrad(0, "", "", 0, "", 0.0); 
            Console.WriteLine("=====Register Postgraduate Student=====");
            Console.Write("Enter Student ID: ");
            postGrad.StudentId = int.Parse(Console.ReadLine());
            Console.Write("Enter Student Name: ");
            postGrad.StudentName = Console.ReadLine();
            Console.Write("Enter Student Surname: ");
            postGrad.StudentSurname = Console.ReadLine();
            Console.Write("Enter Student Age: ");
            postGrad.StudentAge = int.Parse(Console.ReadLine());
            Console.Write("Enter Course Name: ");
            postGrad.CourseName = Console.ReadLine();
            Console.Write("Enter Student GPA: ");
            postGrad.StudentGPA = double.Parse(Console.ReadLine());
            students.Add(postGrad);
            Console.WriteLine("Student has been registered successfully.");
        }

        public void DisplayStudents()
        {
            Console.Clear();
            Console.WriteLine("=====Display All Students=====");
            if (students.Count == 0)
            {
                Console.WriteLine("No students registered.");
                return;
            }
            foreach (var student in students)
            {
                student.DisplayInfo();
                Console.WriteLine("------------------------------");
            }
        }

        public void SearchStudent()
        {
            Console.Clear();
            Console.WriteLine("=====Search for Student=====");
            Console.Write("Enter Student ID to search: ");
            int studentId = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                student.DisplayInfo();
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }

        public void RemoveStudent()
        {
            Console.Clear();
            Console.WriteLine("=====Remove a Student=====");
            Console.Write("Enter Student ID to remove: ");
            int studentId = int.Parse(Console.ReadLine());
            var student = students.FirstOrDefault(s => s.StudentId == studentId);
            if (student != null)
            {
                students.Remove(student);
                Console.WriteLine("Student has been removed successfully.");
            }
            else
            {
                Console.WriteLine("Student not found.");
            }
        }
    }
}
