using System;
using System.Collections.Generic;
using System.Text;

namespace Abstraction
{
    public interface IDrawer
    {
        public void WriteLine(string text = null);

        public void Write(string text=null);

        public void WriteAtPosition(int row, int col, string text = null);
    }
}
