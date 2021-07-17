using System;
using System.Collections.Generic;
using System.Text;

namespace Heap
{
    // Max
    public class Heap<T> where T : IComparable<T>
    {
        private List<T> heap;

        public Heap()
        {
            heap = new List<T>();
        }

        public int Size { get { return heap.Count; } }

        public T GetMax()
        {
            return heap[0];
        }

        public void Add(T element)
        {
            heap.Add(element);
            Heapify(heap.Count - 1);
        }

        private void Heapify(int index)
        {
            if (index == 0) return;

            int parentIndex = (index - 1) / 2;

            if (heap[index].CompareTo(heap[parentIndex]) > 0)
            {
                T temp = heap[index];
                heap[index] = heap[parentIndex];
                heap[parentIndex] = temp;
                Heapify(parentIndex);
            }

        }

        public string DFSInOrder(int index, int indent)
        {
            string result = "";
            int leftChild = 2 * index + 1;
            int rightChild = 2 * index + 2;

            if (leftChild < heap.Count)
            {
                result += DFSInOrder(leftChild, indent + 7);
            }

            result += $"{new string(' ', indent) }{heap[index]}\n";

            if (rightChild < heap.Count)
            {
                result += DFSInOrder(rightChild, indent + 7);
            }

            return result;
        }
    }
}
