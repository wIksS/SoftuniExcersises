using System;
using System.Collections.Generic;

namespace ClubParty
{

    class Program
    {
        class Hall
        {
            public Hall()
            {
                Reservations = new List<int>();
            }

            public int Capacity { get; set; }
            public string Name { get; set; }
            public List<int> Reservations { get; set; }

            public override string ToString()
            {
                return $"{Name} -> {String.Join(", ", Reservations)}";
            }
        }

        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            Stack<string> stack = new Stack<string>(
                Console.ReadLine().Split());

            Queue<Hall> halls = new Queue<Hall>();
            while (stack.Count > 0)
            {

                var current = stack.Pop();
                int people;
                if (int.TryParse(current, out people))
                {
                    if (halls.Count ==0)
                    {
                        continue;
                    }
                    Hall hall = halls.Peek();
                    if (hall.Capacity - people >= 0)
                    {
                        hall.Capacity -= people;
                        hall.Reservations.Add(people);
                    }
                    else
                    {
                        Console.WriteLine(hall);
                        halls.Dequeue();
                        if (halls.Count > 0)
                        {
                            Hall newHall = halls.Peek();
                            newHall.Capacity -= people;
                            newHall.Reservations.Add(people);
                        }

                    }
                }
                else
                {
                    halls.Enqueue(new Hall() { Capacity = capacity, Name = current });
                }
            }
        }
    }
}
