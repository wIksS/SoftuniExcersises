using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace SortedDictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, double> studentGrades = new SortedDictionary<string, double>(new StudentsComparer());

            studentGrades.Add("Goshko", 6);
            studentGrades.Add("Dimitrichko", 3);
            studentGrades.Add("Aabena", 2);

            foreach (KeyValuePair<string, double> studentGrade in studentGrades)
            {
                Console.WriteLine($"{studentGrade.Key} - {studentGrade.Value}");
            }
        }

        class StudentsComparer : IComparer<string>
        {
            public int Compare(string x, string y)
            {
                if (x[0] < y[0])
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
                return x[1].CompareTo(y[1]);
            }
        }
    }
}
