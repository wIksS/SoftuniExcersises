using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] studentsAges = new int[5];

            studentsAges[0] = 19;
            studentsAges[1] = 20;
            studentsAges[2] = 38;
            studentsAges[3] = 45;
            studentsAges[4] = 11;

            Console.WriteLine($"ages[0] = {studentsAges[0]}");
            Console.WriteLine($"ages[1] = {studentsAges[1]}");
            Console.WriteLine($"ages[2] = {studentsAges[2]}");
            Console.WriteLine($"ages[3] = {studentsAges[3]}");
            Console.WriteLine($"ages[4] = {studentsAges[4]}");
            Console.WriteLine($"ages[255] = {studentsAges[255]}");


        }
    }
}
