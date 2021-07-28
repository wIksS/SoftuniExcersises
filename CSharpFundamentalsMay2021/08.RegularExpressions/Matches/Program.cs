using System;
using System.Text.RegularExpressions;

namespace Matches
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"John Smith dasdasds Pesho Petrov Gosho Goshkata";
            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");

            MatchCollection fullNames = nameRegex.Matches(input);

            string replaced = nameRegex.Replace(input, "******");
            Console.WriteLine(repl);
            foreach (Match fullName in fullNames)
            {
                Console.WriteLine(fullName.Value);
                Console.WriteLine($"First name -> {fullName.Groups["firstName"]}");
                Console.WriteLine($"Last name -> {fullName.Groups["lastName"]}");
                Console.WriteLine("\n");
            }
        }
    }
}
