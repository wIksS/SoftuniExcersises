using System;

namespace GenericMethods2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayUtils utils = new ArrayUtils();

            string[] array = utils.GenerateArray<string>(5);
        }
    }

    class ArrayUtils
    {
        public T[] GenerateArray<T>(int numberOfElements)
        {
            T[] array = new T[numberOfElements];

            return array;
        }
    }
}
