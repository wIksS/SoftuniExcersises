using System;
using System.Text.RegularExpressions;

namespace RegexNovember
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"([A-Z][a-z]+) ([A-Z][a-z]+)");

            MatchCollection matches = regex.Matches("Pesho Petrov e priqtel na Georgi Petrov");

            Console.WriteLine(matches[0].Groups.Count);
            foreach (Match match in matches)
            {
                Console.WriteLine("First Name: " + match.Groups[1]);
                Console.WriteLine("Last Name: " + match.Groups[2]);
                Console.WriteLine(match.Success);
                Console.WriteLine(match.Value);
                Console.WriteLine(match.Index);
            }
        }
    }
}
