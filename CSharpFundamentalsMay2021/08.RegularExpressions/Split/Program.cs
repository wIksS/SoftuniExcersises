using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = @"John Smith dasdasds Pesho Petrov ima nqkakyw tekst Gosho Goshkata";
            Regex nameRegex = new Regex(@"[A-Z][a-z]+ [A-Z][a-z]+");

            string[] splitted = nameRegex.Split(input).Where(s => !String.IsNullOrEmpty(s)).ToArray();

            Console.WriteLine(String.Join("\n", splitted));
        }
    }
}
