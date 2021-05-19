using System;

namespace _04.LanguageByCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "USA":
                case "England": Console.WriteLine("English");
                    break;
                case "Argentina":
                case "Mexico":
                case "Spain": Console.WriteLine("Spanish");
                    break;

                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
