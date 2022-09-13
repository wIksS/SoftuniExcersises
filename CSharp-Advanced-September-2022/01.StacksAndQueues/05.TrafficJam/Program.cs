using System;
using System.Collections.Generic;

namespace _05.TrafficJam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int greenCarsToPass = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCount = 0;

            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < greenCarsToPass; i++)
                    {
                        if (cars.Count> 0)
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            passedCount++;
                        }
                    }
                }
                else
                {
                    cars.Enqueue(command);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"{passedCount} cars passed the crossroads.");
        }
    }
}
