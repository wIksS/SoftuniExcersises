using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    public class Component : IComponent
    {
        private List<IComponent> children;
        protected ConsoleColor color = ConsoleColor.White;
        protected Position position;

        public Component(Position position)
        {
            children = new List<IComponent>();
            this.position = position;
        }
        public void AddChild(IComponent child)
        {
            children.Add(child);
        }

        public void Color(ConsoleColor color)
        {
            this.color = color;

            foreach (var child in children)
            {
                child.Color(color);
            }
        }

        public virtual void Draw()
        {
            foreach (var child in children)
            {
                child.Draw();
            }
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.up:
                    position.Y--;
                    break;
                case Direction.down:
                    position.Y++;
                    break;
                case Direction.left:
                    position.X--;
                    break;
                case Direction.right:
                    position.X++;
                    break;
                default:break;
            }

            foreach (var child in children)
            {
                child.Move(direction);
            }
        }
    }
}
