namespace _01.BinaryTree
{
    using System;
    using System.Collections.Generic;

    public class BinaryTree<T> : IAbstractBinaryTree<T>
    {
        public BinaryTree(T value
            , IAbstractBinaryTree<T> leftChild
            , IAbstractBinaryTree<T> rightChild)
        {
            this.Value = value;
            this.LeftChild = leftChild;
            this.RightChild = rightChild;
        }

        public T Value { get; private set; }

        public IAbstractBinaryTree<T> LeftChild { get; private set; }

        public IAbstractBinaryTree<T> RightChild { get; private set; }

        public string AsIndentedPreOrder(int indent)
        {
            return DFSPreOrder(this, 0);
        }

        public string DFSPreOrder(IAbstractBinaryTree<T> node, int indent)
        {
            string result = $"{new string(' ', indent) }{node.Value}\r\n";
            if (node.LeftChild != null)
            {
                result += DFSPreOrder(node.LeftChild, indent +2);
            }
            if (node.RightChild != null)
            {
                result += DFSPreOrder(node.RightChild, indent + 2);
            }

            return result;
        }

        public List<IAbstractBinaryTree<T>> InOrder()
        {
            throw new NotImplementedException();
        }

        public List<IAbstractBinaryTree<T>> PostOrder()
        {
            throw new NotImplementedException();
        }

        public List<IAbstractBinaryTree<T>> PreOrder()
        {
            throw new NotImplementedException();
        }

        public void ForEachInOrder(Action<T> action)
        {
            throw new NotImplementedException();
        }
    }
}
