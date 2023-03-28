using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawIOCompositePattern
{
    public interface IComponent
    {
        void Draw();

        void Move(Direction direction);

        void Color(ConsoleColor color);

        void AddChild(IComponent child);
    }
}
