using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Comparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student pesho = new Student()
            {
                Name = "Pesho",
                Grades = new List<double>() { 2, 2, 2 },
            };

            Student gogi = new Student()
            {
                Name = "Gogi",
                Grades = new List<double>() { 6, 6, 6 },
            };

            Student dimitrichko = new Student()
            {
                Name = "Dimi",
                Grades = new List<double>() { 3,3,3 },
            };

            Console.WriteLine($"Gogi vs Dimitrichko: {gogi.CompareTo(dimitrichko)}");
            Console.WriteLine($"Dimitrichko vs Gogi : {dimitrichko.CompareTo(gogi)}");

            SortedSet<Student> students = new SortedSet<Student>()
            {
                pesho,
                gogi,
                dimitrichko
            };


            foreach (var item in students)
            {
                Console.WriteLine($"{item.Name} {item.Grades.Average()}");
            }

            Console.WriteLine(dimitrichko.CompareTo(3));
        }
    }

    class Student : IComparable<Student>, IComparable<double>
    {
        public string Name { get; set; }

        public List<double> Grades{ get; set; }

        public int CompareTo(Student other)
        {
            double otherStudentAvgGrade = other.Grades.Average();
            return CompareTo(otherStudentAvgGrade);
        }

        public int CompareTo(double otherGrade)
        {
            double currentStudentAvgGrade = Grades.Average();
            double otherStudentAvgGrade = otherGrade;
            //return currentStudentAvgGrade.CompareTo(otherStudentAvgGrade); 

            if (currentStudentAvgGrade > otherStudentAvgGrade)
            {
                return 1;
            }
            else if (currentStudentAvgGrade < otherStudentAvgGrade)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
