using System;
using System.IO;
using System.Linq;
using StudentDatabaseApp.Data;
using StudentDatabaseApp.Models;

namespace StudentDatabaseApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entity Framework Code First - Student Database Example");
            Console.WriteLine("-----------------------------------------------------");

            // Set the data directory to the current directory
            AppDomain.CurrentDomain.SetData("DataDirectory", Directory.GetCurrentDirectory());

            try
            {
                // Create a new student
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    EnrollmentDate = DateTime.Now,
                    Email = "john.doe@example.com"
                };

                // Add the student to the database
                using (var context = new StudentContext())
                {
                    Console.WriteLine("Adding a new student to the database...");
                    
                    // Add the student to the context
                    context.Students.Add(student);
                    
                    // Save changes to the database
                    context.SaveChanges();
                    
                    Console.WriteLine("Student added successfully!");
                    Console.WriteLine();
                }

                // Retrieve and display all students
                using (var context = new StudentContext())
                {
                    Console.WriteLine("Retrieving all students from the database:");
                    
                    var students = context.Students.ToList();
                    
                    foreach (var s in students)
                    {
                        Console.WriteLine($"ID: {s.StudentID}, Name: {s.FirstName} {s.LastName}, Email: {s.Email}, Enrolled: {s.EnrollmentDate.ToShortDateString()}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner exception: {ex.InnerException.Message}");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
