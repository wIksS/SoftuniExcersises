using System;

namespace Shadowing
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tennis = new TennisEvent();
            tennis.Duration = DateTime.Now;
            tennis.PrintEvent();
            tennis.Start();
            Console.WriteLine(tennis.ToString());

            SoftUniList<int> list = new SoftUniList<int>();
            list.Add(5);
            list.Add(5);
            list.Add(5);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
