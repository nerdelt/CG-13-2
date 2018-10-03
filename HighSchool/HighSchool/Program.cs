using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace HighSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            //List of students with name, gpa, and grade
            List<Student> allStudents = new List<Student>() {
             new Student {FirstName = "Marjorie", LastName = "Boucher", GPA = 3.2M, Grade = 11 },
             new Student {FirstName = "Howard", LastName = "Newell", GPA = 2.8M, Grade = 8},
             new Student {FirstName = "Norma", LastName = "Childs", GPA = 3.8M, Grade = 9 },
             new Student {FirstName = "Ruby", LastName = "Ibarra", GPA = 2.4M, Grade = 7 },
             new Student {FirstName = "Joyce", LastName = "Winter", GPA = 4.0M, Grade = 10},
             new Student {FirstName = "Francis", LastName = "Davies", GPA = 3.7M, Grade = 6},
             new Student {FirstName = "Melvin", LastName = "Schultz", GPA = 3.9M, Grade = 9},
             new Student {FirstName = "Edith", LastName = "Gibbons", GPA = 3.0M, Grade = 8},
             new Student {FirstName = "Clyde", LastName = "Westridge", GPA = 4.0M, Grade = 12},
             new Student {FirstName = "Agnes", LastName = "Delarosa", GPA = 3.5M, Grade = 7},
             new Student {FirstName = "Gilbert", LastName = "Kessler", GPA = 2.9M, Grade = 5},
             new Student {FirstName = "Clara", LastName = "Downey", GPA = 3.2M, Grade = 6},
             new Student {FirstName = "Russell", LastName = "Espinosa", GPA = 3.6M, Grade = 8},
             new Student {FirstName = "Florence", LastName = "Vogel", GPA = 3.8M, Grade = 5}
            };

            Console.WriteLine($"The following students are on the High School's Honor Roll.\n");

            //calls the method from the studnet class
            Student.GetHonorRoll(allStudents);
            Console.ReadLine();
        }


    }
}

