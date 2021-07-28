using System;
using System.Text.RegularExpressions;

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"John Smith
Dimitrichko
Pesho Petrov
gosho goshkata
dsadasdas
das
daasdasdasdasdasd asd asdasdas das
John S

AbAbzAzA

JdasdasdasdasdasdasdasdasdasdasdasdasdasdasAdsadasdas

Ja";
            Regex nameRegex = new Regex(@"(?<firstName>[A-Z][a-z]+) (?<lastName>[A-Z][a-z]+)");

            Match match = nameRegex.Match(input);

            Console.WriteLine($"{match.Value} {match.Success} {match.Index} {match.NextMatch().Value}");

            Console.WriteLine($"First Name {match.Groups["firstName"].Value}");
            Console.WriteLine($"Last Name  {match.Groups["lastName"].Value}");
        }
    }
}
