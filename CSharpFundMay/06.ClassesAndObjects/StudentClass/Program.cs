using System;
using System.Collections.Generic;

namespace StudentClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in softuni???");
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < n; i++)
            {
                students.Add(ReadStudent());
            }

            for (int i = 0; i < n; i++)
            {
                PrintStudent(students[i]);
            }
        }

        static Student ReadStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Enter name: ");
            newStudent.name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            newStudent.age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills: ");
            newStudent.skills = Console.ReadLine().Split();

            Console.WriteLine(newStudent);
            return newStudent;
        }

        static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name -> {student.name} -> age ->" +
                $" {student.age} -> skills -> {String.Join(",", student.skills)}");
        }
    }
}
