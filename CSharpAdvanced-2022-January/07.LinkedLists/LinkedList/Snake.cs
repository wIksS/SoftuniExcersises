using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    public class Snake
    {
        private Random random = new Random();
        public DoublyLinkedList<SnakeElement> SnakeElements { get; set; }
        public Snake()
        {
            SnakeElements = new DoublyLinkedList<SnakeElement>();
        }
        public void DrawSnake()
        {
            var snakeNode = SnakeElements.Head;
            while (snakeNode != null)
            {
                Console.SetCursorPosition(snakeNode.Value.Position.Col, snakeNode.Value.Position.Row);
                Console.WriteLine(snakeNode.Value.Character);
                snakeNode = snakeNode.Next;
            }
        }

        public void MoveSnake(Direction direction)
        {
            var snakeHead = SnakeElements.Head;
            var newHead = new Node<SnakeElement>(new SnakeElement()
            {
                Position = new Position(snakeHead.Value.Position),
                Character= snakeHead.Value.Character
            });

            SnakeElements.AddFirst(newHead);

            if (random.Next()% 10 !=0)
            {
                SnakeElements.RemoveLast();
            }

            if (direction == Direction.Right)
            {
                newHead.Value.Position.Col++;
            }
            if (direction == Direction.Left)
            {
                newHead.Value.Position.Col--;
            }
            if (direction == Direction.Up)
            {
                newHead.Value.Position.Row--;
            }
            if (direction == Direction.Down)
            {
                newHead.Value.Position.Row++;
            }
        }
    }
}
