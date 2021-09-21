using System;

namespace _05.Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            switch (country)
            {
                case "Argentina":
                case "Mexico":
                case "Spain": Console.WriteLine("Spanish");
                    break;
                case "England":
                case "USA":
                    Console.WriteLine("English");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
