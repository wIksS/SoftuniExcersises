using System;
using System.Collections.Generic;
using System.Text;

namespace Coupling
{
    class ConsoleWriter : IWriter
    {
        public void Write(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
