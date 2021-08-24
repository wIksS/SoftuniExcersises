using System;
using System.Collections.Generic;
using System.Text;

namespace RedBlackTress
{
    public class RBTree
    {

        private Node addedNode = null;

        public Node Root { get; set; }
        

        public void Insert(int value)
        {

            addedNode = null;
            Insert(Root, value);

            if (addedNode != null)
            {
                Rebalance(addedNode);
            }
        }

        public Node Insert(Node node, int value)
        {
            if (Root == null)
            {
                Root = CreateNewNode(value);
                Root.Color = Color.Black;
                return Root;
            }

            if (node == null)
            {
                return addedNode = CreateNewNode(value);
            }

            if (node.Value > value)
            {
                var newNode = Insert(node.Left, value);
                if (node.Left == null)
                {
                    node.Left = newNode;
                    newNode.Parent = node;
                    //Rebalance(newNode);
                }
            }
            else
            {
                var newNode = Insert(node.Right, value);
                if (node.Right == null)
                {
                    node.Right = newNode;
                    newNode.Parent = node;
                    //Rebalance(newNode);
                }
            }

            return node;
        }

        private void Rebalance(Node node)
        {
            if (node == Root)
            {
                node.Color = Color.Black;
                return;
            }

            Node parent = node.Parent;
            Node grandParent = node.Parent?.Parent;

            if (IsDoubleRed(node))
            {
                Node uncle = GetUncle(node);

                if (uncle == null || uncle.Color == Color.Black)
                {
                    // rotations
                    var newGrandParent = Rotations(node);
                    if (grandParent == Root)
                    {
                        Root = newGrandParent;
                    }
                    else if (newGrandParent.Value < newGrandParent.Parent?.Value)
                    {
                        newGrandParent.Parent.Left = newGrandParent;
                    }
                    else if (newGrandParent.Value >= newGrandParent.Parent?.Value)
                    {
                        newGrandParent.Parent.Right = newGrandParent;
                    }

                    parent.Recolor();
                    grandParent.Recolor();

                    Rebalance(newGrandParent);
                }
                else if (uncle.Color == Color.Red)
                {
                    //recoloring
                    Recolor(uncle, parent, grandParent);
                    Rebalance(grandParent);
                }
            }
        }

        private Node Rotations(Node node)
        {
            Node parent = node.Parent;
            Node grandParent = node.Parent?.Parent;
            Node newGrandParent = grandParent;

            if (parent.Value < node.Value && grandParent.Value < parent.Value)
            {
                newGrandParent = TreeRotations.LeftRotation(grandParent);
            }

            if (parent.Value > node.Value && grandParent.Value > parent.Value)
            {
                newGrandParent = TreeRotations.RightRotation(grandParent);
            }

            if (parent.Value < node.Value && grandParent.Value > parent.Value)
            {
                newGrandParent = TreeRotations.LeftRightRotation(grandParent);
            }

            if (parent.Value > node.Value && grandParent.Value < parent.Value)
            {
                newGrandParent = TreeRotations.RightLeftRotation(grandParent);
            }

            return newGrandParent;
        }

        private void Recolor(Node uncle, Node parent, Node grandParent)
        {
            uncle.Recolor();
            parent.Recolor();
            grandParent.Recolor();
        }

        private Node GetUncle(Node node)
        {
            Node parent = node.Parent;
            Node grandParent = parent?.Parent;

            if (parent.Value < grandParent.Value)
            {
                return grandParent.Right;
            }
            else
            {
                return grandParent.Left;
            }

        }

        private bool IsDoubleRed(Node node)
        {
            if (node.Color == Color.Red && node.Parent?.Color == Color.Red)
                return true;

            return false;
        }

        private Node CreateNewNode(int value)
        {
            return new Node() { Value = value, Color = Color.Red };
        }

        public void DFS(Node root = null)
        {
            if (root == null)
            {
                root = Root;
            }
            Console.BackgroundColor = ConsoleColor.White;

            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();

            DFS(root, 0);
            Console.BackgroundColor = ConsoleColor.White;
        }
        private void DFS(Node node, int indent)
        {
            Console.BackgroundColor = ConsoleColor.White;

            if (node == null) return;
            Console.BackgroundColor = ConsoleColor.White;

            DFS(node.Left, indent + 3);
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write(new string(' ', indent));
            Console.Write(node);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine();
            DFS(node.Right, indent + 3);
            Console.BackgroundColor = ConsoleColor.White;

        }
    }
}
