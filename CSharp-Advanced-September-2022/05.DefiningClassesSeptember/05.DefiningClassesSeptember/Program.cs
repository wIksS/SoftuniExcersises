using System;

namespace _05.DefiningClassesSeptember
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            student.Username = "Goshko";
            //student.Age = 42;
            //student.AverageGrade = 2.50;

            //Console.WriteLine(student.Username);
            //Console.WriteLine(student.Age);
            //Console.WriteLine(student.AverageGrade);

            //student.Graduate();

            Student newStudent = student;

            newStudent.Username = "Dimitrichko";

            Console.WriteLine($"Old student: {student.Username}");
            Console.WriteLine($"New student: {newStudent.Username}");
        }
    }
}
