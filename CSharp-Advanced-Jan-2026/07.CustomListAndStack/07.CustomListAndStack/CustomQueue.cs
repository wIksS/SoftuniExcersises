using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftuniDataStructures
{
    public class CustomQueue
    {
        private LinkedList<int> internalList;

        public CustomQueue()
        {
            internalList = new LinkedList<int>();
        }

        public int Count { get => internalList.Count;  }

        public void Enqueue(int item)
        {
            internalList.AddLast(item);
        }

        public int Peek()
        {
            IsQueueEmpty();

            return internalList.First.Value;
        }

        public int Dequeue()
        {
            IsQueueEmpty();

            int element = internalList.First.Value;
            internalList.RemoveFirst();
            return element;
        }

        public void Clear()
        {
            while (internalList.Count > 0)
            {
                Dequeue();
            }
        }

        public void ForEach(Action<int> action)
        {
            foreach (var item in internalList)
            {
                action(item);
            }
        }

        private void IsQueueEmpty()
        {
            if (internalList.Count == 0)
            {
                throw new InvalidOperationException("Queue is empty!");
            }
        }
    }
}
