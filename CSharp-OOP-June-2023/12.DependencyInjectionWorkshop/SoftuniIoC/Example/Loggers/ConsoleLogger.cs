using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.DependencyInjectionWorkshop.Loggers
{
    internal class ConsoleLogger : ILogger
    {
        private DateTime dateNow;
        public ConsoleLogger(DateTime dateNow)
        {
            this.dateNow = dateNow; 
            Console.WriteLine($"{dateNow}COnsole logger created!");
        }
        public void Log(string s)
        {
            Console.WriteLine($"{dateNow}LOG: {s}");
        }
    }
}
