using DepencyInjectionConstructor.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor.IO
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string msg)
        {
            Console.Write(msg);
        }

        public void WriteLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
