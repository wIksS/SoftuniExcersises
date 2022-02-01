using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderBy
{
    class Student
    {
        public string Name { get; set; }

        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Age=15,Name ="Bobi"},
                new Student(){Age=47,Name ="Gogi"},
                new Student(){Age=22,Name ="Dimitrichko"},
                new Student(){Age=15,Name ="Robi"},
                new Student(){Age=15,Name ="Angelcho"},
            };
            students = students.OrderByDescending(x=>x.Age)
                .ThenBy(x=>x.Name)
                .ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name} -> {student.Age}");
            }
        }
    }
}
