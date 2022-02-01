using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(people);
            int tossCountToRemove = int.Parse(Console.ReadLine());
            int currentTosses = 1;
            while (queue.Count > 1)
            {
                var kidWithPotato = queue.Dequeue();
                if (currentTosses != tossCountToRemove)
                {
                    currentTosses++;
                    queue.Enqueue(kidWithPotato);
                }
                else
                {
                    currentTosses = 1;
                    Console.WriteLine($"Removed {kidWithPotato}");
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
