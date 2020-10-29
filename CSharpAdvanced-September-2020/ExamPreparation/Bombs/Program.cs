using System;
using System.Collections.Generic;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(
                Console.ReadLine().Split(", ").Select(int.Parse).ToList());
            Stack<int> cases = new Stack<int>(
    Console.ReadLine().Split(", ").Select(int.Parse).ToList());

            int datura = 0;
            int cherry = 0;
            int smoke = 0;
            int decrease = 0;
            while (effects.Count > 0 && cases.Count > 0)
            {
                if (datura >= 3 && cherry >= 3 && smoke >= 3)
                {
                    break;
                }

                int currentEffect = effects.Peek();
                int currentCase = cases.Peek() - decrease;
                int combined = currentEffect + currentCase;
                bool bombCreated = false;
                if (combined == 40)
                {
                    datura++;
                    bombCreated = true;
                }
                else if (combined == 60)
                {
                    cherry++;
                    bombCreated = true;
                }
                else if (combined == 120)
                {
                    smoke++;
                    bombCreated = true;
                }

                if (bombCreated)
                {
                    effects.Dequeue();
                    cases.Pop();
                    decrease = 0;
                }
                else if (currentCase <= 0)
                {
                    cases.Pop();
                    decrease = 0;
                }
                else
                {
                    decrease += 5;
                }
            }

            if (datura >= 3 && cherry >= 3 && smoke >= 3)
            {
                Console.WriteLine($"Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine($"Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Effects: {String.Join(", ",effects)}");
            }
            if (cases.Count == 0)
            {

                Console.WriteLine($"Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine($"Bomb Casings: {String.Join(", ", cases)}");
            }

            Console.WriteLine($"Cherry Bombs: {cherry}");
            Console.WriteLine($"Datura Bombs: {datura}");
            Console.WriteLine($"Smoke Decoy Bombs: {smoke}");
        }
    }
}
