using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniDataStructures
{
    public class SoftUniList<T> : IEnumerable<T>
    {
        private T[] internalArray;
        private int index;
        private int capacity;
        private int resizeCount;
        public SoftUniList(int capacity = 4)
        {
            internalArray = new T[capacity];
            index = 0;
        }

        public int Count { get => index; }

        public T this[int i]
        {
            get
            {
                CheckIndex(i);
                return internalArray[i];
            }
            set
            {
                CheckIndex(i);
                internalArray[i] = value;
            }
        }

        public void ForEach(Action<T> action)
        {
            for (int i = 0; i < index; i++)
            {
                action(internalArray[i]);
            }
        }

        public void Add(T value)
        {
            internalArray[index++] = value;
            Resize();
        }

        public void Push(T value)
        {
            Add(value);
        }

        public void Enqueue(T value)
        {
            Add(value);
        }

        public T Pop()
        {
            T element = internalArray[index - 1];
            RemoveAt(index - 1);
            return element;
        }

        public T DequeueSlow()
        {
            if (Count <= 0) throw new InvalidOperationException("List is empty");
            T element = internalArray[0];
            RemoveAt(0);
            return element;
        }

        public void RemoveAt(int indexToRemove)
        {
            CheckIndex(indexToRemove);

            SwapRight(indexToRemove);

            internalArray[index - 1] = default;
            index--;

            if(internalArray.Length/ 4 > index)
            {
                Shrink();
            }
        }

        private void Swap(int first, int second)
        {
            T temp = internalArray[first];
            internalArray[first] = internalArray[second];
            internalArray[second] = temp;
        }

        public T GetAt(int indexValue)
        {
            CheckIndex(indexValue);

            return internalArray[indexValue];
        }

        public bool Contains(int element)
        {
            bool contains = false;
            for (int i = 0; i < index; i++)
            {
                if (internalArray[i].Equals(element))
                    contains = true;
            }

            return contains;
        }

        public void Shrink()
        {
            int size = internalArray.Length;
            bool shouldShrink = false;
            while (size / 2 > index)
            {
                shouldShrink = true;
                size /= 2;
            }

            if (shouldShrink)
            {
                Console.WriteLine($"Shrinking {internalArray.Length} -> {size}");
                TransferInternalArray(size);
            }
        }
        private void Resize()
        {
            if (index < internalArray.Length)
            {
                return;
            }

            Console.WriteLine($"Count: {Count}. Resizing: {++resizeCount}");
            TransferInternalArray(internalArray.Length * 2);
        }

        public void TransferInternalArray(int newLength)
        {
            T[] newArray = new T[newLength];

            for (int i = 0; i < internalArray.Length; i++)
            {
                if(i >= newArray.Length)
                {
                    break ;
                }

                newArray[i] = internalArray[i];
            }

            internalArray = newArray;
        }

        private void SwapRight(int startIndex)
        {
            for (int i = startIndex; i < index - 1; i++)
            {
                Swap(i, i + 1);
                //internalArray[i] = internalArray[i + 1];
            }
        }

        private void ShiftRight(int startIndex)
        {
            for (int i = index; i > startIndex; i--)
            {
                Swap(i, i - 1);
            }

            index++;
            Resize();
        }

        public void Insert(T value, int i)
        {
            CheckIndex(i);

            ShiftRight(i);

            internalArray[i] = value;
        }

        private void CheckIndex(int i)
        {
            if (i >= index || i < 0)
            {
                throw new IndexOutOfRangeException();
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < index; i++)
            {
                yield return internalArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
