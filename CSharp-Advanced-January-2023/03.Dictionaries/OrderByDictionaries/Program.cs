using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> studentGrades = new Dictionary<string, double>();

            studentGrades.Add("Goshko", 6);
            studentGrades.Add("Dimitrichko", 3);
            studentGrades.Add("Sebastiqn", 2);
            studentGrades.Add("Albena", 2);

            studentGrades = studentGrades.OrderByDescending(s => s.Value)
                .ThenByDescending(s=>s.Key)
                .ToDictionary(s => s.Key, s => s.Value);

            foreach (KeyValuePair<string, double> studentGrade in studentGrades)
            {
                Console.WriteLine($"{studentGrade.Key} - {studentGrade.Value}");
            }
        }
    }
}
