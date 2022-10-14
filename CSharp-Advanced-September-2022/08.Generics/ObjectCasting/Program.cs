using System;

namespace ObjectCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 5;

            object numAsObj = num;
            numAsObj = "hello";
            numAsObj = DateTime.Now;
            Console.WriteLine(((DateTime)numAsObj).AddDays(5));

            //int numAsInt = (int)numAsObj;

            //Console.WriteLine(numAsInt);
        }
    }
}
