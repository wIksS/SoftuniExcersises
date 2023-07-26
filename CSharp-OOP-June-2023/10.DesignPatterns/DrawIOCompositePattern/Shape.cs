using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    public class Shape
    {
        protected List<Shape> children;
        protected ConsoleColor color = ConsoleColor.Black;

        public Shape(Position position)
        {
            children = new List<Shape>();
            Position = position;
        }

        public Position Position { get; set; }

        public void AddChild(Shape shape)
        {
            children.Add(shape);
        }

        public virtual void Draw()
        {
            Console.ForegroundColor = color;
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Up:
                    Position.Row--;
                    break;
                case Direction.Down:
                    Position.Row++;
                    break;
                case Direction.Left:
                    Position.Col--;
                    break;
                case Direction.Right:
                    Position.Col++;
                    break;
                default:break;
            }

            foreach (var child in children)
            {
                child.Move(direction);
            }
        }

        public void ChangeColor(ConsoleColor color)
        {
            this.color = color;
            foreach (var child in children)
            {
                child.ChangeColor(color);
            }
        }
    }
}
