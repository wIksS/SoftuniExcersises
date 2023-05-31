using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
    public static class ConsolePrinter
    {
        static ConsolePrinter()
        {
            Color = ConsoleColor.Cyan;
        }

        public static ConsoleColor Color { get; set; }

        public static void WriteLine(string text)
        {
            Console.ForegroundColor = Color;
            Console.WriteLine(text);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
