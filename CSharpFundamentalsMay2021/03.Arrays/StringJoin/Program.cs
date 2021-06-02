using System;

namespace StringJoin
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };

            string joined = String.Join(" ", array);

            Console.WriteLine(joined);



            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length-1)
                {
                    Console.Write($"{array[i]}");
                    break;
                }
                Console.Write($"{array[i]}hopa");
            }
        }
    }
}
