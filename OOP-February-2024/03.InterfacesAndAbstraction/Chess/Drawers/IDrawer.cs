using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess.Drawers
{
    public interface IDrawer
    {
        void Write(string message);

        void WriteLine(string message);
    }
}
