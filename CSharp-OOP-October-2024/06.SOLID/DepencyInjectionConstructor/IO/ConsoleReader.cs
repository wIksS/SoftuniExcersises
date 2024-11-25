using DepencyInjectionConstructor.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor.IO
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();  
        }
    }
}
