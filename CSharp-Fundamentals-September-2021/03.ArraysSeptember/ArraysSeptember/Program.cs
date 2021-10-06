using System;

namespace ArraysSeptember
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[5];
            names[0] = "Goshkata0";
            names[1] = "Goshkata1";
            names[2] = "Goshkata2";
            names[3] = "Goshkata3";
            names[4] = "This is the last cell";
            //names[-5] = "test";
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);

            Console.WriteLine(names.Length);

            Console.WriteLine($"Last element: names[{names.Length-1}]={names[names.Length-1]}");


            Console.WriteLine(names[names.Length]);
        }
    }
}
