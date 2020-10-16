using System;
using System.Collections.Generic;

namespace GenericsMoreDemos
{
    class Program
    {
        static void Main(string[] args)
        {
            Operations<List<int>, List<List<int>>> x;
            List<Operations<int, string>> list = new List<Operations<int, string>>();
            list.Add(new Operations<int, string>());
            var operation = new Operations<int, string>();
            Console.WriteLine(operation.AreEqual(5,"5"));
            Console.WriteLine(operation.ToStringResult(5, ""));
            operation.First = 6;

            var stringOperation = new Operations<string, int>();
            stringOperation.First = "shest";
            Console.WriteLine(stringOperation.ToStringResult("hop", 5));
        }
    }

    class Operations<TFirst, TSecond>
    {
        public TFirst First { get; set; }
        public TSecond Second { get; set; }

        public bool AreEqual(TFirst first, TSecond second)
        {
            return first.Equals(second);
        }

        public void Print(int number)
        {
            Console.WriteLine(number);
        }

        public string ToStringResult(TFirst first, TSecond second)
        {
            return first.ToString() + second.ToString();
        }
    }
}
