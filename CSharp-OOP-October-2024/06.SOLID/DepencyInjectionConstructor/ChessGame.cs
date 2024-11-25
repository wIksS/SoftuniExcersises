using DepencyInjectionConstructor.IO;
using DepencyInjectionConstructor.IO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepencyInjectionConstructor
{
    public class ChessGame
    {
        private IWriter writer;
        private IReader reader;

        // constructor
        public ChessGame(IWriter writer, IReader reader)
        {
            this.writer = writer;
            this.reader = reader;
        }

        public void Run()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine();
                writer.WriteLine("Next move");
            }
        }
    }
}
