
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomHashset
{
    internal class SoftuniHashset
    {

        private List<string>[] internalArray = new List<string>[4];
        private float capacity = 0;
        private int capacityThreshold = 60;
        public void Add(string element)
        {
            int index = HashFunction(element);

            if (internalArray[index] == null)
            {
                internalArray[index] = new List<string>();
            }
            else if (internalArray[index].Contains(element))
            {
                return;
            }

            internalArray[index].Add(element);
            capacity++;

            if (capacity / internalArray.Length * 100 > capacityThreshold)
            {
                ReHash();
            }
        }

        private void ReHash()
        {
            capacity = 0;
            var oldArray = internalArray;
            List<string>[] newArray = new List<string>[internalArray.Length * 2];
            internalArray = newArray;

            foreach (var bucket in oldArray)
            {
                if (bucket != null)
                {
                    foreach (var element in bucket)
                    {
                        Add(element);
                    }
                }
            }

        }

        public bool Contains(string element)
        {
            int index = HashFunction(element);

            return internalArray[index].Contains(element);
        }

        public bool Remove(string element)
        {
            int index = HashFunction(element);

            return internalArray[index].Remove(element);
        }

        private int HashFunction(string element)
        {
            //int buffer = 0;
            //buffer += element[0];
            //if (element.Length > 1)
            //{
            //    buffer += element[element.Length - 1];
            //}

            return Math.Abs(element.GetHashCode()) % internalArray.Length;
        }
    }
}
