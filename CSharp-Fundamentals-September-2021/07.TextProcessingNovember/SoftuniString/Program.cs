using System;
using System.Diagnostics;
using System.Text;

namespace SoftuniString
{
    class Program
    {
        static void Main(string[] args)
        {
            SoftuniString fastString = new SoftuniString();
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
            SoftuniString softuniString = new SoftuniString(count+50);
            watch.Reset();
            watch.Start();
            for (int i = 0; i < count; i++)
            {
                softuniString.Append(i.ToString());
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);
            //Console.WriteLine(result);
            StringBuilder sb = new StringBuilder(count+10);
            watch.Reset();
            watch.Start();
            for (int i = 0; i < count; i++)
            {
                sb.Append(i.ToString());
            }

            watch.Stop();
            Console.WriteLine(watch.ElapsedMilliseconds);

            //  Console.WriteLine(sb);
        }
    }
}
