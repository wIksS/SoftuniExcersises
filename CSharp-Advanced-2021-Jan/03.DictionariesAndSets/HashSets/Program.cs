using System;
using System.Collections.Generic;

namespace HashSets
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> studentsInAdvanced = new HashSet<string>();
            
            string input = Console.ReadLine();
            while (input != "end")
            {
                Console.WriteLine("Enter student in C# advanced course");
                studentsInAdvanced.Add(input);
                input = Console.ReadLine();
            }
            Console.WriteLine($"Count is: {studentsInAdvanced.Count}");
            studentsInAdvanced.Remove("gogi");
            foreach (var student in studentsInAdvanced)
            {
                Console.WriteLine(student);
            }


            while (true)
            {
                Console.WriteLine("Check if student is in course");
                input = Console.ReadLine();

                Console.WriteLine($"{studentsInAdvanced.Contains(input)}");
            }
        }
    }
}
