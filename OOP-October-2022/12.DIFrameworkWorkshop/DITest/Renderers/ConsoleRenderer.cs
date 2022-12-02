using System;
using System.Collections.Generic;
using System.Text;

namespace _12.DIFrameworkWorkshop.Renderers
{
    internal class ConsoleRenderer : IRenderer
    {
        private DateTime date;
        public ConsoleRenderer(DateTime date)
        {
            this.date = date;
            Console.WriteLine("Console renderer created");
        }

        public void Write(object obj)
        {
            Console.Write($"{date}:{obj}");
        }

        public void WriteLine(object obj)
        {
            Console.WriteLine($"{date}:{obj}");
        }
    }
}
