using System;
using System.Collections.Generic;
using System.Text;

namespace CustomHashsetImplementation
{
    public class CustomHashSet
    {
        int size = 8;
        private List<string>[] internalArray ;
        public CustomHashSet(int capacity = 8)
        {
            size = capacity * 8;
            internalArray = new List<string>[size];
        }

        public void Add(string element)
        {
            int index = HashFunction(element);
            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
                internalArray[index].Add(element);
            }
            else
            {
                internalArray[index].Add(element);
            }
        }

        public bool Contains(string element)
        {
            int index = HashFunction(element);
            if (internalArray[index] != null)
            {
                for (int i = 0; i < internalArray[index].Count; i++)
                {
                    if (internalArray[index][i] == element)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
        private int HashFunction(string element)
        {
            return Math.Abs(element.GetHashCode()) % size;
            //UInt64 hashedValue = 3074457345618258791ul;
            //for (int i = 0; i < element.Length; i++)
            //{
            //    hashedValue += element[i];
            //    hashedValue *= 3074457345618258799ul;
            //}

            //return (int)(hashedValue % size);
        }
    }
}
