using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
    class ThreeDPrinter : Printer
    {
        int color = 0;
        public override int Color { get => 5; set => color = value; }

        public override void Print()
        {
            // get material
            Console.WriteLine("Printing in 3d");
        }
    }
}
