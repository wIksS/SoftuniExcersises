using System;

namespace Scope
{
    class Program
    {
        static void Main(string[] args)
        {
            string outer = "I'm inside the Main()";

            for (int i = 0; i < 10; i++)
            {
                string inner = "I'm inside the loop";
            }

            if (true)
            {
                int x = 5;
            }

//            Console.WriteLine(x);

            Console.WriteLine(outer);
            // Console.WriteLine(inner); Error
        }
    }
}
