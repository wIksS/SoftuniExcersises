using System;
using System.Threading;

namespace P01._FileStream_Before
{
    class Program
    {
        static void Main(string[] args)
        {
            Movie progressable = new Movie();
            progressable.Sent = 0;
            progressable.Length = 500;

            Progress progress = new Progress(progressable);

            while (true)
            {
                progressable.Sent += 7;
                Console.WriteLine($"{progress.CurrentPercent()}% sent");
                Thread.Sleep(400);
            }
        }
    }
}
