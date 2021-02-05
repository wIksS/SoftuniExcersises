using System;
using System.Collections.Generic;
using System.IO;

namespace GenericConstraints
{
    class Program
    {
        static void Main(string[] args)
        {
            //var printer = new Printer<Program>();
            ObjectComparer<Printer, Printer> printerComparer = new ObjectComparer<Printer, Printer>();

            ObjectComparer<int, int> comparer = new ObjectComparer<int, int>();

            Console.WriteLine(comparer.IsFirstBigger(7, 6));

            InnerGenericConstraint<IDisposable> constraint = new InnerGenericConstraint<IDisposable>();

            constraint.DoSomething(new StreamReader(""));
            //constraint.DoSomething(5);
        }
    }
}
