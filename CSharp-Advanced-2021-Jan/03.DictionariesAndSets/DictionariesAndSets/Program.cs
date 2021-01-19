using System;
using System.Collections.Generic;

namespace DictionariesAndSets
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(array[0]);

            SortedDictionary<string, int> studentsAges = new SortedDictionary<string, int>()
            {
                {"gogich" ,30},
                {"pepi" ,30},
            };
            
            studentsAges.Add("Gogi", 38);
            studentsAges.Add("Doroteq", 19);


            if (!studentsAges.ContainsKey("joji"))
            {
                Console.WriteLine("Adding joji");
                studentsAges.Add("joji", 13);
            }

            Console.WriteLine(studentsAges["joji"]);

            foreach (KeyValuePair<string,int> student in studentsAges)
            {
                Console.WriteLine($"{student.Key} is {student.Value} old");
            }
        }
    }
}
