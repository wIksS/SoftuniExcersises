using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    internal class Junior : Programmer
    {
        public Junior(string name) :base(name)
        {
            Console.WriteLine($"In junior constructor");
        }
    }
}
