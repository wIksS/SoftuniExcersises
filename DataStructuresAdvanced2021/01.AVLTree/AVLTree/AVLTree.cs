using System;
using System.Collections.Generic;
using System.Text;

namespace AVLTree
{
    public class AVLTree
    {
        // Insert
        // find the correct place to insert
        // Update height and Balance Factors
        // Rebalance tree and Update BF
        // Do it recursively for each node
        public Node Insert(Node node, int value)
        {
            if (node == null)
            {
                return new Node(value);
            }

            if (value < node.Value)
            {
                node.Left = Insert(node.Left, value);
            }
            else
            {
                node.Right = Insert(node.Right, value);
            }

            UpdateFactors(node);

            return UpdateBalance(node);
        }

        private Node UpdateBalance(Node node)
        {

            if (node.Balance == -2)
            {
                if (node.Left.Balance > 0)
                {
                    node = LeftRightRotation(node);
                }
                else
                {
                    node = RighRightRotation(node);
                }
            }
            if (node.Balance == 2)
            {
                if (node.Right.Balance < 0)
                {
                    node = RightLeftRotation(node);
                }
                else
                {
                    node = LeftLeftRotation(node);
                }
            }


            return node;
        }

        private Node LeftRotation(Node node)
        {
            //Console.WriteLine("Left rotation");
            //DFS(node,0);
            //Console.WriteLine("_____________");
            var newNode = node.Right;
            node.Right = newNode.Left;
            newNode.Left = node;

            UpdateFactors(node);
            UpdateFactors(newNode);

            return newNode;
        }

        private Node RightRotation(Node node)
        {
            Console.WriteLine("Right rotation");

            var newNode = node.Left;
            node.Left = newNode.Right;

            newNode.Right = node;

            UpdateFactors(node);
            UpdateFactors(newNode);

            return newNode;
        }

        private Node LeftLeftRotation(Node node)
        {
            return LeftRotation(node);
        }

        private Node RightLeftRotation(Node node)
        {
            node.Right = RighRightRotation(node.Right);
            return LeftLeftRotation(node);
        }

        private Node LeftRightRotation(Node node)
        {
            node.Left = LeftLeftRotation(node.Left);
            return RighRightRotation(node);
        }

        private Node RighRightRotation(Node node)
        {
            return RightRotation(node);
        }

        private void UpdateFactors(Node node)
        {
            int leftHeight = -1;
            int rightHeight = -1;

            if (node.Left != null)
            {
                leftHeight = node.Left.Height;
            }
            if (node.Right != null)
            {
                rightHeight = node.Right.Height;
            }

            node.Height = 1 + Math.Max(leftHeight, rightHeight);

            node.Balance = rightHeight - leftHeight;
        }

        public void DFS(Node node, int indent)
        {
            if (node == null) return;
            DFS(node.Right, indent + 4);

            Console.Write(new string(' ', indent));
            Console.Write($"{node.Value}"); //H:{node.Height} B:{node.Balance}");
            Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine();
            DFS(node.Left, indent + 4);

        }
    }
}
