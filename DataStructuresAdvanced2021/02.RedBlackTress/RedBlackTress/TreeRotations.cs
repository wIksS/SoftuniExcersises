using System;
using System.Collections.Generic;
using System.Text;

namespace RedBlackTress
{
    class TreeRotations
    {

        public static Node LeftRotation(Node node)
        {
            var newRoot = node.Right;
            if(newRoot.Left != null)
                newRoot.Left.Parent = node;
            node.Right = newRoot.Left;
            newRoot.Left = node;
            newRoot.Parent = node.Parent;
            node.Parent = newRoot;

            return newRoot;
        }

        public static Node RightRotation(Node node)
        {
            var newRoot = node.Left;
            if (newRoot.Right != null)
                newRoot.Right.Parent = node;
            node.Left = newRoot.Right;
            newRoot.Right = node;
            newRoot.Parent = node.Parent;
            node.Parent = newRoot;

            return newRoot;
        }

        public static Node RightLeftRotation(Node node)
        {
            node.Right = RightRotation(node.Right);
            return LeftRotation(node);
        }

        public static Node LeftRightRotation(Node node)
        {
            node.Left = LeftRotation(node.Left);
            return RightRotation(node);
        }
    }
}
