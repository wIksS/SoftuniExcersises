using System;
using System.Collections.Generic;
using System.Linq;

namespace InboxManager
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> users
                = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while (command != "Statistics")
            {
                var split = command.Split("->");
                if (command.Contains("Add"))
                {
                    if (users.ContainsKey(split[1]))
                    {
                        Console.WriteLine(
                            $"{split[1]} is already registered");
                    }
                    else
                    {
                        users.Add(split[1],new List<string>());
                    }
                }
                if (command.Contains("Send"))
                {
                    string username = split[1];
                    string email = split[2];
                    users[username].Add(email);
                }
                if (command.Contains("Delete"))
                {
                    string username = split[1];
                    if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                    else
                    {
                        Console.WriteLine($"{username} not found!");
                    }
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Users count: {users.Count}");

             users = users
                .OrderByDescending(user => user.Value.Count)
                .ThenBy(user => user.Key)
                .ToDictionary(item => item.Key, item => item.Value);

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}");
                var emails = user.Value;
                Console.WriteLine(string.Join("\n- ", emails));
                //for (int i = 0; i < emails.Count; i++)
                //{
                //    Console.WriteLine($" - {emails[i]}");
                //}
            }
        }
    }
}
