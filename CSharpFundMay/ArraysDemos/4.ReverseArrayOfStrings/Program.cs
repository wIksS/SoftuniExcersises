using System;

namespace _4.ReverseArrayOfStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split();

            for (int i = 0; i < strings.Length/2; i++)
            {
                string temp = strings[i];
                strings[i] = strings[strings.Length - i - 1];
                strings[strings.Length - i - 1] = temp;
            }

            Console.WriteLine(String.Join(" ", strings));
        }
    }
}
