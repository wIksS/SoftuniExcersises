using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer printer3D = new ThreeDPrinter();
            Printer paperPrinter = new PaperPrinter();
            paperPrinter.Print();
        }
    }
}
