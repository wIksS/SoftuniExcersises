namespace _04.BinarySearchTree
{
    using System;

    public class BinarySearchTree<T> : IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        public BinarySearchTree()
        {
        }

        public BinarySearchTree(Node<T> root)
        {
            Root = root;
            LeftChild = root.LeftChild;
            RightChild = root.RightChild;
        }

        public Node<T> Root { get; private set; }

        public Node<T> LeftChild { get; private set; }

        public Node<T> RightChild { get; private set; }

        public T Value => this.Root.Value;


        // check if value is bigger or smaller than root
        // go left or right accordingly
        // repeat for child element
        // find the first null child element and put the new node there
        public void Insert(T value)
        {
            Insert(value, this.Root);
        }

        public void Insert(T value, Node<T> node)
        {
            if (node == null)
            {
                node = new Node<T>(value, null, null);
                Root = node;
                return;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                if (node.LeftChild == null)
                {
                    node.LeftChild = new Node<T>(value, null, null);
                    return;
                }
                Insert(value, node.LeftChild);
            }
            else
            {
                if (node.RightChild == null)
                {
                    node.RightChild = new Node<T>(value, null, null);
                    return;
                }

                Insert(value, node.RightChild);
            }
        }
        public bool Contains(T value)
        {
            return Contains(value, this.Root);
        }
        public bool Contains(T value, Node<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return true;
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Contains(value, node.LeftChild);
            }
            else
            {
                return Contains(value, node.RightChild);
            }

        }
        public IAbstractBinarySearchTree<T> Search(T value)
        {
            return Search(value, this.Root);
        }
        public IAbstractBinarySearchTree<T> Search(T value, Node<T> node)
        {
            if (node == null)
            {
                return null;
            }
            if (node.Value.CompareTo(value) == 0)
            {
                return new BinarySearchTree<T>(node);
            }

            if (node.Value.CompareTo(value) > 0)
            {
                return Search(value, node.LeftChild);
            }
            else
            {
                return Search(value, node.RightChild);
            }

        }
    }
}

