using System;

namespace ShadowingMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            TennisEvent tennisEvent = new TennisEvent();
            tennisEvent.Print();
            Console.WriteLine(tennisEvent.Duration);
            tennisEvent.Start();

            SoftuniList<int> list = new SoftuniList<int>();
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
