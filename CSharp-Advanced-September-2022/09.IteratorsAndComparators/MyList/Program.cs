using System;

namespace MyList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyListEnumerator<int> enumerator = new MyListEnumerator<int>(new int[] { 1, 2, 3 }, 3);
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }





            return;
            MyList<int> list = new MyList<int>();

            list.Add(1);
            list.Add(22);
            list.Add(3);
            list.Add(44);
            list.Add(5);

            for (int i = 0; true; i++)
            {
                Console.WriteLine(list);
            }


            foreach (int item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
