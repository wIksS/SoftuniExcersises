using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    abstract class Printer
    {
        public void Clean()
        {
            Console.WriteLine("Clean printer");
        }

        public abstract void Print();

        public abstract int Color { get; set; }
        public int Size { get; set; }
    }
}
