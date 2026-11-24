using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPractice
{
    internal class Program
    {
        enum menu
        {
            RegisterStudent = 1,
            DisplayStudent,
            SearchStudent,
            RemoveStudent,
            Exit
        }
        static void Main(string[] args)
        {
            bool exit = false;
            StudentManager manager = new StudentManager();
            do
            {
                try 
                {
                    Console.WriteLine("=====Student Management System=====");
                    Console.WriteLine("1. Register a Student");
                    Console.WriteLine("2. Display All Student");
                    Console.WriteLine("3. Search for Student");
                    Console.WriteLine("4. Remove a Student");
                    Console.WriteLine("5. Exit");
                    Console.WriteLine("=================================");
                    Console.Write("Please select an option from the above menu(1-5): ");
                    int input = int.Parse(Console.ReadLine());

                    menu choice = (menu)input;
                    switch(choice)
                    {
                        case menu.RegisterStudent:
                            manager.RegisterStudent();
                            break;
                        case menu.DisplayStudent:
                            manager.DisplayStudents();
                            break;
                        case menu.SearchStudent:
                            manager.SearchStudent();
                            break;
                        case menu.RemoveStudent:
                            manager.RemoveStudent();
                            break;
                        case menu.Exit:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid option. Please select a valid option from the menu.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An ERROR has occurred: " + ex.Message);
                }
            } while (!exit);
        }
    }
}
