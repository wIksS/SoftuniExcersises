using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Common
{
    internal class Logger : ILogger
    {
        public Logger()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("A new Logger instance was created!!!");
            Console.ForegroundColor = ConsoleColor.White;

        }
        public void Log(string message)
        {
            Console.WriteLine($"Logging {message}");
        }
    }
}
