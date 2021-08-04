using System;
using System.Text;

namespace FundamentalsExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                if (command == "TakeOdd")
                {
                    string odd ="";

                    for (int i = 1; i < password.Length; i += 2)
                    {
                        odd +=password[i];
                    }

                    password = odd.ToString();
                    Console.WriteLine(password);
                }
                if (command.Contains("Cut"))
                {
                    string[] splitted = command.Split();
                    int index = int.Parse(splitted[1]);
                    int length = int.Parse(splitted[2]);

                    password = password.Remove(index, length);
                    Console.WriteLine(password);
                }
                if (command.Contains("Substitute"))
                {
                    string[] splitted = command.Split();
                    string oldString = splitted[1];
                    string newString = splitted[2];

                    if (password.IndexOf(oldString) < 0)
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    else
                    {
                        password = password.Replace(oldString, newString);
                        Console.WriteLine(password);
                    }

                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: { password}");
        }
    }
}
