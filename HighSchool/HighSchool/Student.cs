using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HighSchool
{
    class Student
    {
        //all the properties needed to identify student 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal GPA { get; set; }
        public int Grade { get; set; }

        public static void GetHonorRoll(List<Student> studentsList)
        {
            //LINQ query 
            var honorRoll = studentsList.Where(s => s.GPA >= 3.0M && (s.Grade >= 9 && s.Grade <= 12));


            var highGrade = honorRoll.OrderByDescending(g => g.Grade).ThenByDescending(g => g.GPA).ThenBy(g => g.LastName).ThenBy(g => g.FirstName);

            //printing out honor roll students 
            foreach (var student in highGrade)
            {
                Console.WriteLine($"Name: {student.FirstName} {student.LastName}, GPA: {student.GPA}, Grade: {student.Grade}.\n");
                
            }
             
        }  

    }
}
