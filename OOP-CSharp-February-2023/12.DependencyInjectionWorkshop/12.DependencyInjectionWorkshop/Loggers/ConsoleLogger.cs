using _12.DependencyInjectionWorkshop.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        private readonly DateTime dateToday;

        public ConsoleLogger(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public void Log(object text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
