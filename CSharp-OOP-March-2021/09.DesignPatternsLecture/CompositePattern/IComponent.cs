using System;
using System.Collections.Generic;
using System.Text;

namespace CompositePattern
{
    interface IComponent
    {
        void Add(IComponent component);

        void Remove(IComponent component);

        void Draw();

        void Move(Position position);
    }
}
