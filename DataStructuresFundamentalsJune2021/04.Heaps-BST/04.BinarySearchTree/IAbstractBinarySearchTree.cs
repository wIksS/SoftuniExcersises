namespace _04.BinarySearchTree
{
    using System;

    public interface IAbstractBinarySearchTree<T>
        where T : IComparable<T>
    {
        void Insert(T element);

        bool Contains(T element);

        IAbstractBinarySearchTree<T> Search(T element);

        Node<T> Root { get;  }

        Node<T> LeftChild { get;  }

        Node<T> RightChild { get; }

        T Value { get; }
    }
}
