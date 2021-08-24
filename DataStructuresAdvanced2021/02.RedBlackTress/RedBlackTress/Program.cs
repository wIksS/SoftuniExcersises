using System;

namespace RedBlackTress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            RBTree tree = new RBTree();

            Random rand = new Random();

            for (int i = 1; i <= 50; i++)
            {
                var x= rand.Next(0, 10000);
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine($"Adding{x}");
                Console.WriteLine();
                tree.Insert(x);
                if (i%10==0)
                {
                    tree.DFS();

                }
            }

            Console.BackgroundColor = ConsoleColor.White;
        }
    }
}
