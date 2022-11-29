using System;
using System.Collections.Generic;
using System.Text;

namespace Formula1.Models
{
    public class Ferrari : FormulaOneCar
    {
        public Ferrari(string model, int horsepower, double engineDisplacement) : base(model, horsepower, engineDisplacement)
        {
        }
    }
}
