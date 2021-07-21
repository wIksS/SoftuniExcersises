using System;
using System.Linq;

namespace _03.WordsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "b", "z", "abca", "c", "azads", "aaadsa" };//Console.ReadLine().Split();

            //words = words.Where(word => word.Length % 2 == 0).ToArray();

            words = words.OrderByDescending(w => w[0])
                .ThenBy(w =>
                {
                    if (w.Length <= 1)
                    {
                        return w[0];
                    }

                    return w[1];
                })
                .ToArray();

            Console.WriteLine(String.Join(",", words));
        }
    }
}
