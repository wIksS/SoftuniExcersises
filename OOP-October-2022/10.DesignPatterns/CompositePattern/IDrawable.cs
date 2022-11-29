using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    public interface IDrawable
    {
        void Draw();

        void Move(Direction direction);
        void ChangeColor(ConsoleColor color);

        void AddChild(IDrawable child);

        void RemoveChild(IDrawable child);
    }
}
