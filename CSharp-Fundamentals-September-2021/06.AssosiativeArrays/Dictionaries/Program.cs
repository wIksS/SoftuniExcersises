using System;
using System.Collections.Generic;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dictionary<Dictionary<int, int>, int> x;
            // All students with specific grade
            Dictionary<int, List<string>> studentGrades = new Dictionary<int, List<string>>();

            studentGrades.Add(2, new List<string>());

            studentGrades[2].Add("Pesho");
            studentGrades[2].Add("Gosho");
            studentGrades[2].Add("Dimi");

            Console.WriteLine(studentGrades[2][0]);
        }
    }
}
