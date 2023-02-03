using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxOfT
{
    public class Box<T>
    {
        private int count;
        private List<T> list;

        public Box()
        {
            list = new List<T>();
        }

        public int Count { get { return this.count; } }

        public void Add(T element)
        {
            count++;
            list.Add(element);
        }

        public T Remove()
        {
            count--;
            T removedElement = list[list.Count - 1];
            list.Remove(removedElement);

            return removedElement;
        }
    }
}
