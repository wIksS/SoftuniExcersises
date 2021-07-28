using System;
using System.Text.RegularExpressions;

namespace _01.MatchName
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ivan Ivanov, Ivan ivanov, ivan Ivanov, IVan Ivanov, Test Testov, Ivan	Ivanov
            string input = Console.ReadLine();
            MatchCollection matches = Regex.Matches(input, @"\b[A-Z][a-z]+ [A-Z][a-z]+\b");

            foreach (Match item in matches)
            {
                Console.Write(item + " ");
            }
        }
    }
}
