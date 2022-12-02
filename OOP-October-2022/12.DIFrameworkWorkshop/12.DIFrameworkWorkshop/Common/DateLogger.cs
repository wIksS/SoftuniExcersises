using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Common
{
    internal class DateLogger : ILogger, IDateLogger
    {
        private readonly DateTime date;

        public DateLogger(int day, int month, int year)
        {
            date = new DateTime(year,month,day);
        }

        public void Log(string message)
        {
            Console.WriteLine($"DATE: {date.ToString("dd/MM/yyyy")} --- {message}");
        }
    }
}
