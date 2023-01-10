using System;
using System.Collections.Generic;

namespace QueueDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> tickets = new Queue<string>();

            while (true)
            {
                Console.WriteLine("What is your ticket? ");
                string ticket = Console.ReadLine();

                if (ticket == "no")
                {
                    for (int i = 0; i < 2; i++)
                    {
                        string currentTicket = tickets.Dequeue();
                        Console.WriteLine($"The answer to {currentTicket} is I cannot help.");
                    }
                }
                else
                {
                    tickets.Enqueue(ticket);
                }
            }
        }
    }
}
