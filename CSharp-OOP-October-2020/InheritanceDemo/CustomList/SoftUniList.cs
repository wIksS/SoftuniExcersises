using System;

namespace CustomList
{
    class SoftUniList<T> : List<T>
    {
        public override void Add(T item)
        {
            Console.WriteLine("Adding elements rulz" + item);
            base.Add(item);
        }
    }
}
