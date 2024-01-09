using Renderers;
using Renderers.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DIWorkshopIOC.Loggers
{
    class ConsoleLogger : ILogger
    {
        public ConsoleLogger(IRenderer renderer)
        {
            renderer.WriteLine("Console Logger created!!!", new Position(5,6));
        }
        public void Log(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{DateTime.Now}:{message}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
