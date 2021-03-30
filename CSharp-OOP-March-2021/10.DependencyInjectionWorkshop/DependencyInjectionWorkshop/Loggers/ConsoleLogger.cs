using DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionWorkshop.Loggers
{
    class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
