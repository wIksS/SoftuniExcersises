using System;

namespace ValueAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int aa = a;
            aa += 5;
            Console.WriteLine(a);
            Console.WriteLine(aa);

            int[] array = new int []{ 1, 2, 3 };
            int[] array2 = array;

            array2[0] = 55;

            Console.WriteLine(array[0]);
            Console.WriteLine(array2[0]);
        }
    }
}
