using LinkedList;
using System;
using System.Collections.Generic;
using System.Threading;

namespace LinkedListSoftuni
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            Snake snake = new Snake();
            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(13, 16)
            }));
            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(12, 16)
            }));
            snake.SnakeElements.AddFirst(new Node<SnakeElement>(new SnakeElement()
            {
                Character = '@',
                Position = new Position(11, 16)
            }));

            Direction direction = Direction.Up;

            while (true)
            {
                direction = ChangeDirection(direction);

                Console.Clear();

                snake.DrawSnake();
                snake.MoveSnake(direction);

                Thread.Sleep(100);
            }
        }

        private static Direction ChangeDirection(Direction direction)
        {
            if (Console.KeyAvailable)
            {
                var ch = Console.ReadKey(true).Key;
                switch (ch)
                {
                    case ConsoleKey.LeftArrow:
                        return Direction.Left;
                    case ConsoleKey.RightArrow:
                        return Direction.Right;
                    case ConsoleKey.UpArrow:
                        return Direction.Up;
                    case ConsoleKey.DownArrow:
                        return Direction.Down;
                }
            }

            return direction;
        }
    }
}











//DoublyLinkedList linkedList = new DoublyLinkedList();

//linkedList.AddFirst(new Node(1));
//linkedList.AddFirst(new Node(2));
//linkedList.AddFirst(new Node(3));
//linkedList.AddFirst(new Node(4));

//linkedList.ForEach(node =>
//{
//    Console.WriteLine(node.Value);
//});
//Console.WriteLine("Reversed");
//linkedList.Reverse();

//linkedList.ForEach(node =>
//{
//    Console.WriteLine(node.Value);
//});
//Console.WriteLine("Reversed");
//linkedList.Reverse();

//linkedList.ForEach(node =>
//{
//    Console.WriteLine(node.Value);
//});
//Console.WriteLine("Reversed");
//linkedList.Reverse();
//foreach (var node in linkedList.ToArray())
//{
//    Console.WriteLine("In Foreach");
//    Console.WriteLine(node.Value);
//}