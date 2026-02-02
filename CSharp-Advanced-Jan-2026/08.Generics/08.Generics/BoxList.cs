using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Generics
{
    public class BoxList<T> where T : IComparable<T>
    {
        public BoxList()
        {
            Data = new List<Box<T>>();
        }

        public List<Box<T>> Data { get; set; }

        public void Swap(int firstIndex, int secondIndex)
        {
            Box<T> temp = Data[firstIndex];
            Data[firstIndex] = Data[secondIndex];
            Data[secondIndex] = temp;
        }

        public int GetBiggerBoxes(Box<T> box)
        {
            List<Box<T>> biggerBoxes = Data.Where(b => b.CompareTo(box) > 0).ToList();

            return biggerBoxes.Count;
        }
    }
}
