using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    public class Programmer : Employee
    {
        public sealed override void Work()
        {
            Console.WriteLine($"Programistite ne rabotqt!!!");
        }


    }
}
