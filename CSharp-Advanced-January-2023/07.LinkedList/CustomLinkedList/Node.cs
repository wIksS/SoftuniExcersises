using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomLinkedList
{
    public class Node
    {
        public Node(int value, Node next = null, Node previous = null)
        {
            Value = value;
            Previous = previous;
            Next = next;
        }

        public int Value { get; set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }

        public override string ToString()
        {
            return $"{Previous?.Value} <- {Value} -> {Next?.Value}"; 
        }
    }
}
