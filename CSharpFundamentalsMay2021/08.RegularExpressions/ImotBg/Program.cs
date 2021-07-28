using System;
using System.IO;
using System.Text.RegularExpressions;

namespace ImotBg
{
    class Program
    {
        static void Main(string[] args)
        {
            string imotbg = "";
            using (StreamReader reader = new StreamReader("../../../imotbg.html"))
            {
                imotbg = reader.ReadToEnd();
            }

            var regex = new Regex(@"<div class=""price"">(?<price>.*?)<a.*<\/div>[\S\s]*?<a.*?>(?<room>.*?)<[\S\s]*?<a.*?>(?<loc>.*?)<\/a>");

            var matches = regex.Matches(imotbg);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Price: {match.Groups["price"]}");
                Console.WriteLine($"Rooms: {match.Groups["room"]}");
                Console.WriteLine($"Location: {match.Groups["loc"]}");

                Console.WriteLine(new string('-', 50));
            }

        }
    }
}
