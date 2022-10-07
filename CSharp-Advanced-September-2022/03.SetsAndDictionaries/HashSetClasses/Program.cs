using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace HashSetClasses
{
    class Student : IEqualityComparer<Student>
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            if (x.Age == y.Age)
            {
                return true;
            }

            return false;
        }

        public int GetHashCode([DisallowNull] Student obj)
        {
            return obj.GetHashCode();
        }
    }

    class StudentComparer : IEqualityComparer<Student>
    {
        public bool Equals([AllowNull] Student x, [AllowNull] Student y)
        {
            if (x.Name==y.Name && x.Age == y.Age)
            {
                return true;
            }

            return false;
        }

        public  int GetHashCode([DisallowNull] Student obj)
        {
            return obj.Age.GetHashCode() + obj.Name.GetHashCode();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>(new StudentComparer());


            students.Add(new Student() { Name = "Pesho", Age = 15});
            students.Add(new Student() { Name = "Pesho", Age = 15});
            students.Add(new Student() { Name = "Pesho", Age = 15 });


            //students.Add(goshoStudent);
            //students.Add(goshoStudent);
            //students.Add(goshoStudent);

            foreach (var student in students)
            {
                Console.WriteLine($"{student.Name}, {student.Age}");
            }
        }
    }
}
