using System;
using System.Collections.Generic;
using System.Text;

namespace AVLTree
{
    public class Node
    {
        public Node(int value, int height = 0, int balance = 0)
        {
            Value = value;
            Height = height;
            Balance = balance;
        }

        public int Value { get; set; }

        public int Height { get; set; }

        public int Balance { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }
    }
}
