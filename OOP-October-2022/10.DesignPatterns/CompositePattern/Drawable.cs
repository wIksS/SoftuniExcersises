using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public class Drawable : IDrawable
    {
        protected List<IDrawable> children;
        protected char[,] shape;
        public Drawable(Position position) :this()
        {
            Position = position;    
        }
        public Drawable()
        {
            children = new List<IDrawable>();
            Color = ConsoleColor.White;    
        }

        public Position Position { get; set; }

        public ConsoleColor Color{ get; set; }

        public void AddChild(IDrawable child)
        {
            children.Add(child);
        }

        public virtual void Draw()
        {
            foreach (var child in children)
            {
                Console.ForegroundColor = Color;
                child.Draw();
                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public virtual void Move(Direction direction)
        {
            foreach (var child in children)
            {
                child.Move(direction);
            }
        }

        public void RemoveChild(IDrawable child)
        {
            children.Remove(child);
        }

        public void ChangeColor(ConsoleColor color)
        {
            Color = color;

            foreach (var child in children)
            {
                child.ChangeColor(color);
            }
        }
    }
}
