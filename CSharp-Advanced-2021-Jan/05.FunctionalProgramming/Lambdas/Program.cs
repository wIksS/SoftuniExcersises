using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int[] evenNumbers = array
                //.Where(x => x % 2 == 0)
                //.Where((x) => x % 2 == 0)
                .Where((int x, int index) =>
                {
                    Console.WriteLine($"Checking at array[{index}] {x} % 2 == 0 -> {x % 2 == 0}");

                    return x % 2 == 0;
                })
                .Where(x => x > 0)
                .ToArray();

            //List<int> eventNumbersCustom = new List<int>();

            //for (int i = 0; i < array.Length; i++)
            //{
            //    if (IsEven(array[i]))
            //    {
            //        eventNumbersCustom.Add(array[i]);
            //    }
            //}

            Console.WriteLine(String.Join(" ", evenNumbers));
          //  Console.WriteLine(String.Join(" ", eventNumbersCustom));
        }

        static bool IsEven(int number)
        {
            return number % 2 == 0;
        }
    }
}
