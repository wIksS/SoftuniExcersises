using System;
using System.Collections.Generic;

namespace _03.Dictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> studentAges = new Dictionary<string, int>();

            studentAges["Pesho"] = 21;
            studentAges["Pesho"] = 51;

            studentAges["Goshko"] = 31;

            Console.WriteLine(studentAges["Pesho"]);

            if (studentAges.ContainsKey("Nqma go"))
            {
                Console.WriteLine(studentAges["Nqma go"]);
            }

            studentAges.Add("Dimitrichko", 45);
            //studentAges.Add("Dimitrichko", 46);

            Console.WriteLine(studentAges["Dimitrichko"]);

            foreach (KeyValuePair<string,int> studentAge in studentAges)
            {
                Console.WriteLine($"{studentAge.Key} - {studentAge.Value}");
            }

        }
    }
}
