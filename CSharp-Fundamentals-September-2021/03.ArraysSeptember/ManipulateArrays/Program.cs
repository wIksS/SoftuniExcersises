using System;

namespace ManipulateArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[] 
            {
                "Pesho",
                "Goshkata",
                "Dimitrichko",
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
            };

            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"names[{i}]={names[i]}");
            }

        }
    }
}
