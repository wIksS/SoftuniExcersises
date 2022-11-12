using System;
using System.Collections;
using System.Collections.Generic;

namespace AsKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEnumerable collection = new Queue<int>();

            List<int> list = collection as List<int>;

            if (collection is I)
            {

            }
            if (list != null)
            {
                Console.WriteLine(list.Count);
            }
        }

        
    }
}
