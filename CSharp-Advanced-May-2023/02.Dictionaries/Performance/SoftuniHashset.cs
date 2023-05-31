using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Performance
{
    public class SoftuniHashset
    {
        int resizeCount = 0;
        private List<string>[] array;
        private float capacity = 0;

        public SoftuniHashset(int capacity = 8)
        {
            array = new List<string>[capacity];
        }


        public SoftuniHashset(IEnumerable<string> initial)
        {
            array = new List<string>[initial.Count()];

            foreach (var item in initial)
            {
                Add(item);
            }
        }

        public void Add(string element)
        {
            if (Contains(element)) return;
            ulong index = HashFunction(element);

            if (array[index] == null)
            {
                array[index] = new List<string>();
            }

            array[index].Add(element);
            capacity++;
            if (capacity / array.Length > 0.60)
            {
                resizeCount++;

                // Console.WriteLine($"Capacity is: {capacity / array.Length} ... resizing" );
                Resize();
                //Console.WriteLine($"Resize count: {resizeCount}");
            }
        }

        private void Resize()
        {
            capacity = 0;
            var oldArray = array;
            array = new List<string>[array.Length * 2];

            foreach (var list in oldArray)
            {
                if (list == null)
                {
                    continue;
                }

                foreach (var item in list)
                {
                    Add(item);
                }
            }
        }

        public bool Contains(string element)
        {
            ulong index = HashFunction(element);
            if (array[index] == null)
            {
                return false;
            }
            return array[index].Contains(element);
        }

        private ulong HashFunction(string element)
        {
            //int sum = 0;
            //var index = element.Length >= 3 ?3: element.Length;
            //for (int i = 0; i < index; i++)
            //{
            //    sum+= element[i];
            //}
            UInt64 hashedValue = 3074457345618258791ul;
            for (int i = 0; i < element.Length; i++)
            {
                hashedValue += element[i];
                hashedValue *= 3074457345618258799ul;
            }
            return hashedValue % (ulong)array.Length;

            //return Math.Abs(element.GetHashCode()) % array.Length;
        }
    }
}
