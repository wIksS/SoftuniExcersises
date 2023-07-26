using _12.DependencyInjectionWorkshop.Loggers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        private ILogger logger;
        public ConsoleRenderer(ILogger logger)
        {
            Console.WriteLine("Console renderer created!");
            this.logger = logger;
        }
        public void Write(string s)
        {
            logger.Log("Writing!!!");
            Console.Write(s);
        }

        public void WriteLine(string s)
        {
            logger.Log("Writing new lines!!!");

            Console.WriteLine(s);
        }
    }
}
