using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerator<T>, IEnumerable<T>
    {
        private List<T> data;
        private int index;
        public ListyIterator(List<T> inputData)
        {
            data = inputData;
            Reset();
        }
        public T Current
        {
            get
            {
                if(data == null || data.Count == 0 || index >= data.Count)
                {
                    throw new InvalidOperationException("Invalid Operation!");
                }

                return data[index];
            }
        }

        object IEnumerator.Current => Current;

        public void Dispose()
        {

        }

        //public void Print()
        //{
        //    if(data == null || data.Count == 0)
        //    {
        //        Console.WriteLine("Invalid");
        //    }
        //    else
        //    {
        //        Console.WriteLine(Current);
        //    }
        //}

        public bool MoveNext()
        {
            if (!HasNext())
            {
                return false;
            }

            return ++index < data.Count;
        }

        public bool HasNext()
        {
            return index + 1 < data.Count;
        }

        public void Reset()
        {
            index = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in data)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
