using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Tire
    {
        public Tire(int years, double pressure)
        {
            Years = years;
            Pressure = pressure;
        }

        public int Years { get; set; }

        public double Pressure { get; set; }
    }
}
