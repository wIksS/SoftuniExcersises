using System;

namespace IndexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "C# is the best. Java is not. C# is better";// Console.ReadLine();
            int firstJavaIndex = text.IndexOf("nqma go");
            int secondJavaIndex = text.IndexOf("java",firstJavaIndex+1);

            if (secondJavaIndex >= 0)
            {
                Console.WriteLine("Java found :(((");
            }
            else
            {
                Console.WriteLine("No Java No troubles");
            }
        }
    }
}
