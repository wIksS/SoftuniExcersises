using System;
using System.Text.RegularExpressions;

namespace Registration
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = 
                new Regex(@"U\$([A-Z][a-z]{2,})U[$]P@\$([A-Za-z]{5,}[A-Za-z0-9]*[0-9])P@\$");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                string login = Console.ReadLine();
                Match match = regex.Match(login);
                if (match.Success)
                {
                    count++;
                    Console.WriteLine("Registration was successful");
                    Console.WriteLine(
                        $"Username: {match.Groups[1]}, Password: {match.Groups[2]}");
                }
                else
                {
                    Console.WriteLine("Invalid username or password");
                }
            }

            Console.WriteLine($"Successful registrations: {count}");
        }
    }
}
