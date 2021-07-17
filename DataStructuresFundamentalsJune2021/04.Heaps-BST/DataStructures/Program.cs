using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //          1 
            //        5    7 
            //       2  3 9 11 

            Node<int> root = new Node<int>(1,
                    new Node<int>(5,
                        new Node<int>(2),
                        new Node<int>(3)),
                    new Node<int>(7,
                        new Node<int>(9),
                        new Node<int>(11))
                );

            BinaryTree<int> tree = new BinaryTree<int>(root);
            Console.WriteLine(tree.DFSPreOrder(tree.Root, 0));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(tree.DFSInOrder(tree.Root, 0)); 
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(tree.DFSPostOrder(tree.Root, 0));
        }
    }
}
