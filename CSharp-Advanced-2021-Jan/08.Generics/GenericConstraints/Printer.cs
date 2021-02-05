using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class Printer: IComparable
    {
        public static void Print<T>(T page)
            where T : IDisposable
        {
            page.Dispose();
        }

        public int CompareTo(object obj)
        {
            return 1;
        }
    }
}
