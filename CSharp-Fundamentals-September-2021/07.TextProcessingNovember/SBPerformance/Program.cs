using System;
using System.Diagnostics;
using System.Text;

namespace SBPerformance
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            string result = "";
            int count = 70000;
            watch.Start();
            for (int i = 0; i < count; i++)
            {
                result += i.ToString();
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.WriteLine(result);
            StringBuilder sb = new StringBuilder();
            watch.Reset();
            watch.Start();
            for (int i = 0; i < count; i++)
            {
                sb.AppendLine(i.ToString());
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            Console.WriteLine(sb);
        }
    }
}
