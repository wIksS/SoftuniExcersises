using System;
using System.Collections.Generic;

namespace AssosiativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Student names and their grades
            Dictionary<string, float> studentsDictionary = new Dictionary<string, float>();

            studentsDictionary.Add("Goshko", 2);
            studentsDictionary.Add("Dimitrichko", 5.99f);
            studentsDictionary.Add("Maria", 5);

            Console.WriteLine(studentsDictionary["Dimitrichko"]);

            studentsDictionary["Dimitrichko"] = 4.99f;

            Console.WriteLine(studentsDictionary["Dimitrichko"]);

        }
    }
}
