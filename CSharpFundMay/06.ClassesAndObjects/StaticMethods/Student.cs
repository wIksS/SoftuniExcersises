using System;
using System.Collections.Generic;
using System.Text;

namespace StaticMethods
{
    public class Student
    {
        public static int StudentsCount;
        public string Name;
        public int Age;
        public string[] Skills;

        public void AgeStudent()
        {
            this.Age++;
        }

        public static void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name -> {student.Name} -> age ->" +
               $" {student.Age} -> skills -> {String.Join(",", student.Skills)}");
        }

        public static Student ReadStudent()
        {
            Student newStudent = new Student();
            Console.WriteLine("Enter name: ");
            newStudent.Name = Console.ReadLine();
            Console.WriteLine("Enter age: ");
            newStudent.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter skills: ");
            newStudent.Skills = Console.ReadLine().Split();

            Console.WriteLine(newStudent);
            Student.StudentsCount++;
            return newStudent;
        }
    }
}
