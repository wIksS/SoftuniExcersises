using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Square : Shape
    {
        public override double Area => this.Side * this.Side;

        public double Side { get; set; }

    }
}
