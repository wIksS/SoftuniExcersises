using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Performance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 1_000_00;
            //List<int> list = new List<int>();

            //Stopwatch watch = new Stopwatch();
            //watch.Start();
            //for (int i = 0; i < n; i++)
            //{
            //    // remove
            //    list.Insert(0,i);
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    //pop
            //    list.RemoveAt(0);
            //}

            //watch.Stop();
            //Console.WriteLine(watch.ElapsedMilliseconds);

            Stack<int> stack = new Stack<int>();

            var watch = new Stopwatch();
            watch.Start();
            for (int i = 0; i < n; i++)
            {
                // remove
                stack.Push(i);
            }

            for (int i = 0; i < n; i++)
            {
                //pop
                stack.Contains(i);
                stack.Pop();
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
        }
    }
}
