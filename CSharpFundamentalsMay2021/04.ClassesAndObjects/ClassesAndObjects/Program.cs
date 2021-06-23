using System;
using System.Collections.Generic;

namespace ClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            Student firstStudent = new Student();
            firstStudent.age = 25;
            firstStudent.grades = new List<double>() { 2, 3 };
            firstStudent.name = "Gogi";
            PrintStudent(firstStudent);

            Console.WriteLine(String.Join(" ", firstStudent.grades));
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine(student.name);
        }
    }

    class Student
    {
        public string name;
        public int age;
        public List<double> grades;
    }
}
