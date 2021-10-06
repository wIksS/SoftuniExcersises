using System;
using System.Linq;

namespace _07.IdenticalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split().Select(int.Parse).ToArray(); 
            int[] secondArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            if (firstArray.Length != secondArray.Length)
            {
                Console.WriteLine("Not equal");
                return;
            }

            bool areEqual = true;
            for (int i = 0; i < firstArray.Length; i++)
            {
                if (firstArray[i] != secondArray[i])
                {
                    areEqual = false;
                    //Console.WriteLine("Not equal");
                    //return;
                }
            }

            Console.WriteLine(areEqual);

        }
    }
}
