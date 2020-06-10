using System;

namespace ValueAndRefTypes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = arr1;
            arr2[0] = 55;
            Console.WriteLine(arr1[0]);
            int[] arr = new int[] { 1, 2 };
            ChangeArray(arr);
            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            int x = 55;
            ChangeVariableInt(ref x);
            Console.WriteLine(x);
        }

        static void ChangeArray(int[] numbers)
        {
            numbers[0] = 55;
            numbers[1] = 33;
        }

        static void ChangeVariableInt(ref int x)
        {
            x = 5;
        }
    }
}
