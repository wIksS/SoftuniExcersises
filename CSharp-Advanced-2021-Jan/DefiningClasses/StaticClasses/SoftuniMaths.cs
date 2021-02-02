using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    class SoftuniMaths
    {
        public readonly static int SomeConst = 55;
        public const int SomeConst2 = 55;
        public int PI { get; set; }

        public static int Something { get; set; }

        public static int Add(int a, int b)
        {
            return a + b + Something;
        }

        public int Multiply(int a, int b)
        {
            return a * b + this.PI;
        }

    }
}
