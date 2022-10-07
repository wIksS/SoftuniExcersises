using System;
using System.Collections.Generic;
using System.Text;

namespace CustomHashSet
{
    class SoftuniHashSet
    {
        private List<string>[] internalArray;

        public SoftuniHashSet(int capacity)
        {
            internalArray = new List<string>[capacity];
        }

        public void Add(string value)
        {
            int index = HashFunction(value);
            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
            }
            internalArray[index].Add(value);
        }

        public bool Contains(string value)
        {
            int index = HashFunction(value);
            if (internalArray[index] == null) return false;
    
            for (int i = 0; i < internalArray[index].Count; i++)
            {
                if (internalArray[index][i] == value)
                {
                    return true;
                }
            }

            return false;
        }

        //"Gosho, Go" -> 3
        public int HashFunction(string value)
        {
            //return 0;
            //return Math.Abs(value.GetHashCode()) % internalArray.Length;
            int hash=0;            
            
            for (int i = 0; i < value.Length; i++)
            {
                hash += value[i];
                hash += (hash << 10);
                hash ^= (hash >> 6);
            }
            hash += (hash << 3);
            hash ^= (hash >> 11);
            hash += (hash << 15);
            return Math.Abs(hash) % internalArray.Length;
        }
    }
}
