using System;

namespace DataTypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentAge = int.Parse(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                string inner = "I'm inside the loop";
                Console.WriteLine(inner);
            }

            string outer = "I'm inside the Main()";
            Console.WriteLine(outer);
            //Console.WriteLine(inner);

        }
    }
}
