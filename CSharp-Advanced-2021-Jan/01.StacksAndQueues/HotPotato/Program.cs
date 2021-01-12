using System;
using System.Collections.Generic;

namespace HotPotato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            Queue<string> potatoQueue = new Queue<string>(children);
            int potatoTosses = 0;
            while (potatoQueue.Count > 1)
            {
                potatoTosses++;

                //Console.WriteLine(potatoTosses);
                //Console.WriteLine(String.Join(" ", potatoQueue.ToArray()));
                string kid = potatoQueue.Dequeue();
                if (potatoTosses ==n)
                {
                    potatoTosses = 0;
                    Console.WriteLine("Removed " + kid);
                }
                else
                {
                    potatoQueue.Enqueue(kid);
                }
            }

            Console.WriteLine("Last is " + potatoQueue.Dequeue());
        }
    }
}
