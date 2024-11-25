using DepencyInjectionConstructor.IO;
using DepencyInjectionConstructor.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor
{
    public class ChessGamePropertyInversion
    {
        public IWriter Writer { get; set; }

        public IReader Reader { get; set; }

        public void Run()
        {
            //Reader.Read();
            Writer.WriteLine("Next move");
        }
    }
}
