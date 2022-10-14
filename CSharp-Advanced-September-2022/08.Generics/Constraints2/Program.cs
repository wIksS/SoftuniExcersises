using CustomList;
using System;

namespace Constraints2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> list = new GenericList<int>();
            list.Add(55);
            list.Add(23);
            list.Add(67);
            list.Add(1);

            Console.WriteLine(list.GetMax());

            GenericList<DateTime> dates = new GenericList<DateTime>();
            dates.Add(DateTime.Now);
            dates.Add(DateTime.Now.AddDays(5));
            dates.Add(DateTime.Now.AddDays(-5));

            Console.WriteLine(dates.GetMax());

            //Console.WriteLine(5.CompareTo(6));
            //Console.WriteLine(5.CompareTo(5));
            //Console.WriteLine(6.CompareTo(5));
        }
    }
}
