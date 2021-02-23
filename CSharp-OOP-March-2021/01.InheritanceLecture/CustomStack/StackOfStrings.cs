using System;
using System.Collections.Generic;
using System.Text;

namespace CustomStack
{
    public class StackOfStrings<T> : Stack<T>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public Stack<T> AddRange(IEnumerable<T> range)
        {
            foreach (var item in range)
            {
                this.Push(item);
            }

            return this;
        }
    }
}
