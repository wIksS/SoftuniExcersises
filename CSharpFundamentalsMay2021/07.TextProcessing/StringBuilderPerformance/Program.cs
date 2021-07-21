using System;
using System.Diagnostics;
using System.Text;

namespace StringBuilderPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder builder = new StringBuilder(Console.ReadLine());
            int count = 40000;
            Console.WriteLine("Test concatenation: ");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            string text = "";
            //12345671011121010000
            for (int i = 0; i < count; i++)
            {
                text += i;
            }
            watch.Stop();
            Console.WriteLine($"String concatanetion: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();

            watch.Start();
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(i);
            }

            watch.Stop();
            Console.WriteLine($"StringBuilder concatanetion: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();




            Console.WriteLine("Test insert: ");
            watch = new Stopwatch();
            watch.Start();
            text = "";
            for (int i = 0; i < count; i++)
            {
                int start = text.Length - 10 >= 0 ? text.Length - 10 : 0;
                text = text.Insert(start, i.ToString());
            }
            watch.Stop();
            Console.WriteLine($"String insert: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();

            watch.Start();
            result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                int start = result.Length - 10 >= 0 ? result.Length - 10 : 0;

                result.Insert(start, i.ToString());
            }

            watch.Stop();
            Console.WriteLine($"StringBuilder insert: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();


            Console.WriteLine("Test replace: ");
            Random rand = new Random();
            watch = new Stopwatch();
            watch.Start();
            text = "";
            for (int i = 0; i < count * 15; i++)
            {
                text = text.Replace(rand.Next(0, text.Length).ToString(), "*");
            }
            watch.Stop();
            Console.WriteLine($"String replace: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();

            watch.Start();
            result = new StringBuilder();
            for (int i = 0; i < count * 15; i++)
            {
                result.Replace(rand.Next(0, result.Length).ToString(), "*");
            }

            watch.Stop();
            Console.WriteLine($"StringBuilder replace: {watch.ElapsedMilliseconds} miliseconds");
            watch.Reset();
        }
    }
}
