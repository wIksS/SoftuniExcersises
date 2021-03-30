using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    class Component : IComponent
    {
        private List<IComponent> children;


        public Component(Position position)
        {
            children = new List<IComponent>();
            Position = position;
        }

        public Position Position { get; set; }

        public virtual void Draw()
        {
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public virtual void Move(Position position)
        {
            Position.X += position.X;
            Position.Y += position.Y;

            foreach (var child in children)
            {
                child.Move(position);
            }
        }

        public virtual void Add(IComponent component)
        {
            children.Add(component);
        }

        public virtual void Remove(IComponent component)
        {
            children.Remove(component);
        }
    }
}
