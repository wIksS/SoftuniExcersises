using System;

namespace FunctionalProgrammingCycle
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "5";
            x = "6";
            Loop(() =>
            {
                Console.WriteLine("Bobi");
            }, 10);
        }

        static  void Loop(Action work, int n)
        {
            if (n == 0)
            {
                return;
            }

            work();
            Loop(work,n - 1);
        }
    }
}
