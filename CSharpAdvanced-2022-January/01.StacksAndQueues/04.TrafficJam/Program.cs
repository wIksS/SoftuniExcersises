using System;
using System.Collections.Generic;

namespace _04.TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();

            string command = Console.ReadLine();
            int passedCount = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Count == 0)
                        {
                            break;
                        }
                        var car = cars.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        passedCount++;
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
