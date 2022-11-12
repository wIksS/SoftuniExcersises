using System;

namespace Indexators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> list = new List<char>();

            Console.WriteLine(list[53]);

            list[20] = 30;


            Console.WriteLine(list[-1]);
        }
    }

    class List<T>
    {
        int position = 0;
        public int this[int index]
        {
            get
            {
                return position;
            }
            set
            {
                position = index + value;
            }
        }
    }
}
