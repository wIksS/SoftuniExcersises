using System;
using System.Collections.Generic;
using System.Text;

namespace TimeAnalisys
{
    class SetElement<T> where T : IComparable<T>
    {
        public SetElement()
        {
            Numbers = new List<T>();
        }
        public List<T> Numbers { get; set; }

    }

    public class SoftuniHashSet<T> where T : IComparable<T>
    {
        private SetElement<T>[] array;
        private float capacity = 0;

        public SoftuniHashSet(int initialCapacity = 2)
        {
            array = new SetElement<T>[initialCapacity];
        }
        public void Add(T number, bool updateCapacity = true)
        {
            int index = HashFunction(number);

            if (array[index] == null)
            {
                var setElement = new SetElement<T>();
                array[index] = setElement;
            }

            array[index].Numbers.Add(number);
            if (updateCapacity)
            {
                UpdateCapacity();
            }
        }

        public bool Remove(T number)
        {
            int index = HashFunction(number);
            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Numbers.Count; i++)
                {
                    if (array[index].Numbers[i].CompareTo(number) == 0)
                    {
                        array[index].Numbers.Remove(number);
                        capacity--;
                        return true;
                    }
                }
            }

            return false;
        }

        public bool Contains(T number)
        {
            int index = HashFunction(number);
            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Numbers.Count; i++)
                {
                    if (array[index].Numbers[i].CompareTo(number) == 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void UpdateCapacity()
        {
            capacity++;
            float capacityPercentage = capacity / array.Length * 100;
            //Console.WriteLine($"Capacity Percentage: {capacityPercentage}");
            if (capacityPercentage > 60)
            {
                // Console.WriteLine($"Remeasure");
                var oldArray = array;
                array = new SetElement<T>[array.Length * 2];
                for (int i = 0; i < oldArray.Length; i++)
                {
                    if (oldArray[i] != null)
                    {
                        foreach (var number in oldArray[i].Numbers)
                        {
                            Add(number, false);
                        }
                    }
                }
            }
        }

        private int HashFunction(T number)
        {

            //int h = number;

            //h = (h << 5) | (h >> 27); // 5-bit cyclic shift of the running sum
            //h += (int)number; // add in next character


            return Math.Abs(number.GetHashCode() % array.Length);
        }
    }
}
