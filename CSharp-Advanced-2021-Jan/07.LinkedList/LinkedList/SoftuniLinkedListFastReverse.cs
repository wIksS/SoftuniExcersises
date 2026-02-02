//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace LinkedList
//{
//    class SoftuniLinkedListFastReverse<T>
//    {
//        private int count = 0;

//        private bool reversed = false;

//        public Node<T> Head { get; set; }

//        public Node<T> Tail { get; set; }

//        public void Reverse()
//        {
//            var temp = Head;
//            Head = Tail;
//            Tail = temp;
//            reversed = !reversed;
//        }

//        public void AddLast(Node<T> node)
//        {
//            count++;
//            if (Tail == null)
//            {
//                Head = node;
//                Tail = node;
//                return;
//            }

//            node.Previous = Tail;
//            Tail.Next = node;
//            Tail = node;
//        }

//        public void Foreach(Action<Node<T>> action)
//        {
//            Node<T> currentNode = Head;
//            while (currentNode != null)
//            {
//                action(currentNode);
//                if (reversed)
//                {
//                    currentNode = currentNode.Previous;
//                }
//                else
//                {
//                    currentNode = currentNode.Next;
//                }
//            }
//        }
//    }
//}
