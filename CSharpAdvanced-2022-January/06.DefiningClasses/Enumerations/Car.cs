using Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    // accessibility modifiers
    public class Car
    {
        public string Name { get; set; }

        public int Mileage { get; set; }

        public CarState CarState { get; set; }
    }
}

