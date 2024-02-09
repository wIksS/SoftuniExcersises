using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniHashSetNS
{
    internal class SoftUniHashSet
    {
        private List<string>[] internalArray;
        private double elementsCount = 0;
        private int maxCapacity = 99;

        public SoftUniHashSet()
        {
            internalArray = new List<string>[8];
        }

        public void Add(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
            }

            internalArray[index].Add(element);
            elementsCount++;

            if (elementsCount/internalArray.Length * 100 > maxCapacity)
            {
                Resize();
            }
        }

        private void Resize()
        {
            elementsCount = 0;
            List<string>[] oldInternalArray = internalArray;

            internalArray = new List<string>[internalArray.Length * 2];

            for (int i = 0; i < oldInternalArray.Length; i++)
            {
                if (oldInternalArray[i] != null)
                {
                    for (int j = 0; j < oldInternalArray[i].Count; j++)
                    {
                        Add(oldInternalArray[i][j]);
                    }
                }
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

        public int HashFunction(string element)
        {
            // return Math.Abs(element.GetHashCode()) % internalArray.Length;
            UInt64 hashedValue = 3074457345618258791ul;
            for (int i = 0; i < element.Length; i++)
            {
                hashedValue += element[i];
                hashedValue *= 3074457345618258799ul;
            }

            return (int)(hashedValue % (ulong)internalArray.Length);
        }
    }
}
