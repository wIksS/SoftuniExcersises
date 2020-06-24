using System;

namespace StaticBuiltIn
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dateNow = DateTime.Now;
            Console.WriteLine(dateNow);

            Random instance = new Random();

            while (true)
            {
                Console.WriteLine(instance.Next());
            }
        }
    }
}
