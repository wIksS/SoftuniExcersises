using System;
using System.Text.RegularExpressions;

namespace RegexReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            string replaced = regex.Replace("Pesho Petrov e priqtel na Georgi Petrov", "***** ******");

            string[] splitted = regex.Split("Pesho Petrov e priqtel na Georgi Petrov");

            Console.WriteLine(replaced);

            Console.WriteLine(String.Join("\n", splitted));
        }
    }
}
