using System;
using System.Collections.Generic;
using System.Text;

namespace Shadowing
{
    class SoftUniList<T> : List<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("Adding elements rulz" + item);
            base.Add(item);
        }
    }
}
