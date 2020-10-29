using System;
using System.Collections.Generic;
using System.Text;

namespace BaseKeywordDemo
{
    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine(
                $"Max speed is: {MaxSpeed}");
        }
    }
}
