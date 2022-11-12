using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    internal class Passport : Document
    {
        public int Size { get; set; }

        public void Print(int x, object y = null)
        {
            Console.WriteLine();
        }
    }
}
