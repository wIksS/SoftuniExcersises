using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClass
{
    public class Student
    {
        public string name;
        public int age;
        public string[] skills;

        void PrintStudent(Student student)
        {
            Console.WriteLine($"Student name -> {student.name} -> age ->" +
               $" {student.age} -> skills -> {String.Join(",", student.skills)}");
        }
    }
}
