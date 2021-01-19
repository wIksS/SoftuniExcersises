using System;
using System.Collections.Generic;

namespace MultiDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> studentsGrades = new Dictionary<string, List<int>>();

            studentsGrades.Add("Gogi", new List<int>());
            studentsGrades["Gogi"].Add(3);
        }
    }
}
