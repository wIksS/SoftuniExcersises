using System;
using System.Collections.Generic;
using System.Text;

namespace _06.LinkedList
{
    class StackWithLinkedList
    {
        private SoftuniLinkedLIst linkedList = new SoftuniLinkedLIst();

        public int Count { get { return linkedList.Count; } }

        public void Add(int number)
        {
            linkedList.AddFirst(number);
        }

        public int Pop()
        {
            return linkedList.RemoveFirst();
        }
    }
}
