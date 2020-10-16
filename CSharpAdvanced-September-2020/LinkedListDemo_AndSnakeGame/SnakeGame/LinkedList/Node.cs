using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeGame
{
    public class Node
    {
        public Node(Position value)
        {
            this.Value = value;
        }

        public Position Value { get; set; }

        public Node Next { get; set; }

        public Node Previous { get; set; }
    }
}
