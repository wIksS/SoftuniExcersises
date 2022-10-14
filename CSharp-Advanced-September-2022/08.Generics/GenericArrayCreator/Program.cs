using System;

namespace GenericArrayCreator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int[] numbers = ArrayCreator.Create(10, 42);
            Console.WriteLine(String.Join(",", numbers));

            string[] strings = ArrayCreator.Create(100, "ZDR");
            Console.WriteLine(String.Join(",", strings));
        }
    }
}
