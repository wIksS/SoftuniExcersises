using System;
using System.Collections;
using System.Collections.Generic;

namespace _09.IteratorsAndComparators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<int> numbers = new int[] { 1, 2, 3 };
            List<int> list = new List<int>() { 1,2,3};
            MyList<int> myList = new MyList<int>();

            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }
        }
    }

    class MyList<T> : IEnumerable<T>
    {
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
