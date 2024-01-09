using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDI.Loggers
{
    class ConsoleLogger : ILogger
    {
        public ConsoleLogger(IRenderer renderer, DateTime datetime)
        {
            renderer.WriteLine("Console Logger created!!!");
        }
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{DateTime.Now}:{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
