using System;
using System.Collections;
using System.Collections.Generic;

namespace IntEnumerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IntEnumerable collection = new IntEnumerable();

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }

            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }


    // IEnumerator != IEnumerable
    class IntEnumerator : IEnumerator<int>
    {
        private int currentNumber = 0;
        public int Current => currentNumber;

        object IEnumerator.Current => Current;

        public void Dispose() { }

        public bool MoveNext()
        {
            if (currentNumber++ > 20)
            {
                return false;
            }

            return true;
        }

        public void Reset()
        {
            currentNumber = 0;
        }
    }

    class IntEnumerable : IEnumerable<int>
    {
        public IEnumerator<int> GetEnumerator()
        {
            return new IntEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
