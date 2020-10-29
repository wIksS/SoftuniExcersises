using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class SoftuniList<T> : List<T>
    {
        public void Add(T item)
        {
            Console.WriteLine(
                "Adding the best elements since 1902 " + item);
            base.Add(item);
        }
    }
}
