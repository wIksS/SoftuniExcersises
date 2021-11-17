using System;
using System.Text.RegularExpressions;

namespace _02.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter date:");

                Console.WriteLine($"Valid date: {Regex.IsMatch(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>([0-9]{4})")}");
            }
            MatchCollection matches = Regex.Matches(Console.ReadLine(), @"(?<day>[0-9]{2})(?<separator>[\.\-\/])(?<month>[A-Z][a-z]{2})\k<separator>([0-9]{4})");

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups[1]}");
            }

        }
    }
}
