using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class Constraints<T>
        where T : List<T>
    {
        public void Print(T elements)
        {
            Console.WriteLine(elements.Count);
            foreach (var item in elements)
            {
                Console.WriteLine(item);
            }
        }
    }
}
