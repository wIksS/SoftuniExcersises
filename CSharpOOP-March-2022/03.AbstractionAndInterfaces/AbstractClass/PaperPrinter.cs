using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class PaperPrinter : Printer
    {
        public override void Print()
        {
            Console.WriteLine("Printing to paper");
        }
    }
}
