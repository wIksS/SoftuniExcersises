using System;

namespace FunctionalProgrammingVsOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Student[]
            {
                new Student{Name="Gogi", Age=37, AverageGrade=3.37 },
                new Student{Name="Niki", Age=37, AverageGrade=4.37 },
                new Student{Name="Dori", Age=37, AverageGrade=2.37 },
            };

            var studentsOOP = new StudentsOOP();
            Console.WriteLine(studentsOOP.IsHoliday());

            studentsOOP.RemoveDumbStudents(students);

            foreach (var student in students)
            {
                if (student != null)
                {
                    Console.WriteLine(student.Name);
                }
            }

            var studentsFP = new StudentFP();

            studentsFP.IsHoliday(DateTime.Now);

            var smartStudents = studentsFP.RemoveDumbStudents(students);

            foreach (var item in smartStudents)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
