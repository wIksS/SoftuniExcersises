using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    public class Shape
    {
        public Shape(Position position)
        {
            Children = new List<Shape>();
            Position = position;
            Color = ConsoleColor.White;
        }

        public List<Shape> Children { get; set; }

        public ConsoleColor Color { get; set; }

        public Position Position { get; set; }

        public virtual void Draw()
        {
            foreach (var child in Children)
            {
                child.Draw();
            }
        }

        public void Move(Direction direction)
        {
            if (Position != null)
            {
                switch (direction)
                {
                    case Direction.up:
                        Position.Top--;
                        break;
                    case Direction.down:
                        Position.Top++;
                        break;
                    case Direction.left:
                        Position.Left--;
                        break;
                    case Direction.right:
                        Position.Left++;
                        break;
                    default: break;
                }
            }

            foreach (var child in Children)
            {
                child.Move(direction);
            }
        }
        public void ChangeColor(ConsoleColor color)
        {
            Color = color;

            foreach (var child in Children)
            {
                child.ChangeColor(color);
            }
        }
    }
}
