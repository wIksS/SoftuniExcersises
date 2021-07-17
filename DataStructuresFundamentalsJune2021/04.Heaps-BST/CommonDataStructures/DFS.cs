using System;

namespace CommonDataStructures
{
    public class DFS
    {
        public static string DFSPreOrder<T>(Node<T> node, int indent)
        {
            string result = $"{new string(' ', indent) }{node.Value}\n";
            if (node.LeftChild != null)
            {
                result += DFSPreOrder(node.LeftChild, indent + 3);
            }
            if (node.RightChild != null)
            {
                result += DFSPreOrder(node.RightChild, indent + 3);
            }

            return result;
        }

        public static string DFSInOrder<T>(Node<T> node, int indent)
        {
            string result = "";
            if (node.LeftChild != null)
            {
                result += DFSInOrder(node.LeftChild, indent + 3);
            }

            result += $"{new string(' ', indent) }{node.Value}\n";

            if (node.RightChild != null)
            {
                result += DFSInOrder(node.RightChild, indent + 3);
            }

            return result;
        }

        public static string DFSPostOrder<T>(Node<T> node, int indent)
        {
            string result = "";
            if (node.LeftChild != null)
            {
                result += DFSPostOrder(node.LeftChild, indent + 3);
            }

            if (node.RightChild != null)
            {
                result += DFSPostOrder(node.RightChild, indent + 3);
            }

            result += $"{new string(' ', indent) }{node.Value}\n";
            return result;
        }
    }
}
