using System;

namespace StringArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] studentNames = new string[n];

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = Console.ReadLine();
            }

            Console.WriteLine("All student are: ");
            for (int i = 0; i < studentNames.Length; i++)
            {
                Console.Write(studentNames[i] + " ");
            }
        }
    }
}
