using System;

namespace LogicalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"true && true = {true && true}");
            Console.WriteLine($"true && false = {true && false}");
            Console.WriteLine($"false && true = {false && true}");
            Console.WriteLine($"false && false = {false && false}");


            Console.WriteLine($"true || true = {true || true}");
            Console.WriteLine($"true || false = {true || false}");
            Console.WriteLine($"false || true = {false || true}");
            Console.WriteLine($"false || false = {false || false}");

            string name = "Pesho";
            int age = 23;
            bool isMale = true;
            if (name == "Pesho" && age > 10 && (isMale == true || age > 30))
            {

            }
        }
    }
}
