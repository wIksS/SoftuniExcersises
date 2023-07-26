using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        public ConsoleLogger()
        {
            Console.WriteLine("COnsole logger created!");
        }
        public void Log(string s)
        {
            Console.WriteLine($"\nLOG: {s}\n");
        }
    }
}
