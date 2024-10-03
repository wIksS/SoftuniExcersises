using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private Stack<T> queue;

        public Box()
        {
            queue = new Stack<T>();
        }

        public void Add(T element)
        {
            queue.Push(element);
        }

        public T Remove()
        {
            //T firstElement = queue[0];
            //queue.RemoveAt(0);

            return queue.Pop();
        }

        public int Count { get { return queue.Count; } }
    }
}
