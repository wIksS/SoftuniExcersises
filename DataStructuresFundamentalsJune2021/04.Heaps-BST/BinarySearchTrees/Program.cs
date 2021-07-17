using CommonDataStructures;
using System;
using System.Collections.Generic;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 25; i+=2)
            {
                list.Add(i);
            }

            BST<int> tree = new BST<int>();

            Insert(tree, 0, list.Count, list);

            Console.WriteLine($"Find: {57} -> {tree.Contains(57, tree.Root)}");

            Console.WriteLine(DFS.DFSInOrder(tree.Root, 0));

            Console.WriteLine($"Find: {8} -> {tree.Contains(8, tree.Root)}");

        }

        private static void Insert(BST<int> tree, int start, int end, List<int> list)
        {
            if (start >= end)
            {
                return;
            }

            var middle = (start + end) / 2;
            tree.Insert(list[middle], tree.Root);
            Insert(tree, start, middle -1, list);
            Insert(tree, middle + 1, end, list);

        }
    }
}
