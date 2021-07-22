using _02.Data;
using _02.Data.Models;
using System;

namespace TestData
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data = new Data();

            data.Add(new User(5, null));
            data.Add(new User(1, null));
            data.Add(new User(8, null));
            data.Add(new User(2, null));
            data.Add(new User(3, null));

            while (data.Size > 0)
            {
                Console.WriteLine(data.DequeueMostRecent().Id);
            }
        }
    }
}
