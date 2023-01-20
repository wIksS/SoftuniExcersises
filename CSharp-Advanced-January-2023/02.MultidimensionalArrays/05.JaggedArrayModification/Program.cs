using System;
using System.Linq;

namespace _05.JaggedArrayModification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                jaggedArray[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }

            string command = Console.ReadLine().ToLower();

            while (command != "end")
            {
                string[] splitted = command.Split();
                int row = int.Parse(splitted[1]);
                int col = int.Parse(splitted[2]);
                int value = int.Parse(splitted[3]);

                if (row < 0 || col < 0 || row >= jaggedArray.Length || col >= jaggedArray[row].Length)
                {
                    Console.WriteLine("Invalid coordinates");
                }
                else
                {

                    if (splitted[0] == "add")
                    {
                        jaggedArray[row][col] += value;
                    }
                    else
                    {
                        jaggedArray[row][col] -= value;
                    }
                }

                command = Console.ReadLine().ToLower();
            }

            for (int row = 0; row < jaggedArray.Length; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
