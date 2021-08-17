using System;

namespace AVLTree
{
    class Program
    {
        static void Main(string[] args)
        {
            AVLTree tree = new AVLTree();
            var root = tree.Insert(null, 1);
            root = tree.Insert(root, 50);
            tree.DFS(root, 0);
            Console.WriteLine("-----------");
            root = tree.Insert(root, 23);
            tree.DFS(root, 0); Console.WriteLine("-----------");

            root = tree.Insert(root, 52);
            tree.DFS(root, 0); Console.WriteLine("-----------");

            root = tree.Insert(root, 53);
            tree.DFS(root, 0); Console.WriteLine("-----------");

            root = tree.Insert(root, 21);
            tree.DFS(root, 0); Console.WriteLine("-----------");

            root = tree.Insert(root, 0);
            Random random = new Random();
            //for (int i = 2; i <= 50; i++)
            //{
            //    //root = tree.Insert(root, random.Next(0, 100));
            //    root = tree.Insert(root, random.Next(0, 100));
            //    // tree.DFS(root, 0);
            //    //Console.WriteLine("-----------");
            //    // tree.DFS(root, 0);

            //}

            tree.DFS(root, 0);
        }
    }
}
