using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftDependecyInjection
{
    internal class ConsoleLogger : ILogger
    {
        private DateTime dateToday;

        public ConsoleLogger(DateTime dateToday)
        {
            this.dateToday = dateToday;
        }

        public void Log(string message)
        {
            Console.WriteLine($"{dateToday}:{message}");
        }
    }
}
