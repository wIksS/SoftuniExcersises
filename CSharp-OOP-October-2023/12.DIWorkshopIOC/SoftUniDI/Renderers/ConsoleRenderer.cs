using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Renderers.Renderers
{
    public class ConsoleRenderer : IRenderer
    {
        private DateTime dateToday;
        public ConsoleRenderer(DateTime dateTime)
        {
            this.dateToday = dateTime;
        }

        public void Write(string text)
        {
            Console.WriteLine(dateToday);
            Console.Write(text);
        }

        public void WriteLine(string text)
        {
            Console.WriteLine(dateToday);
            Console.WriteLine(text);
        }
    }
}
