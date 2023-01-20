using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace _03.StudentAverageGrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 + 2 +3 + 4 = 10 /4 = 2.5
            Console.WriteLine(new List<int>() { 1,2,3,4}.Average());
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            Dictionary<string, List<decimal>> studentGrades = new Dictionary<string, List<decimal>>();

            int n = int.Parse(Console.ReadLine());

            // Pesho 2
            // Pesho 3
            // Pesho 4
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string studentName = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (!studentGrades.ContainsKey(studentName))
                {
                    studentGrades.Add(studentName, new List<decimal>());
                }

                studentGrades[studentName].Add(grade);
            }


            foreach (var studentGrade in studentGrades)
            {
                Console.WriteLine($"{studentGrade.Key} -> {string.Join(" ", studentGrade.Value.Select(x=>$"{x:f2}").ToList())} (avg: {studentGrade.Value.Average():f2})");
                //Console.Write($"{studentGrade.Key} -> ");

                //foreach (var grade in studentGrade.Value)
                //{
                //    Console.Write($"{grade:f2} ");
                //}

                //Console.WriteLine($"(avg: {studentGrade.Value.Average():f2})");
            }
        }
    }
}
