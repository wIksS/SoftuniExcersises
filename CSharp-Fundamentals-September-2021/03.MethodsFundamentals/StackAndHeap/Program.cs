using System;

namespace StackAndHeap
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 6;
            AddNumbers(a, b);

            Console.WriteLine("In main");
            Console.WriteLine(a);
            Console.WriteLine(b);

            int[] array = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("In main before method");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            AddNumbers(array);

            Console.WriteLine("In main after method");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void AddNumbers(int[] array)
        {
            Console.WriteLine("In method");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] += 5;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void AddNumbers(int a, int b)
        {
            a += 5;
            b += 6;

            Console.WriteLine("In method");
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
