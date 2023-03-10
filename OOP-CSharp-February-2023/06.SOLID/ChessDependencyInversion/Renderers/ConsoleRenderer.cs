using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessDependencyInversion.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        public void Clear()
        {
            Console.Clear();
        }

        public void Write(object msg)
        {
            Console.Write(msg);
        }

        public void WriteLine(object msg)
        {
            Console.WriteLine(msg);
        }
    }
}
