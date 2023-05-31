using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniLinkedList
{
    public class Node
    {
        public Node(int value, Node next = null, Node previous=null)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }

        public int Value { get; set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
