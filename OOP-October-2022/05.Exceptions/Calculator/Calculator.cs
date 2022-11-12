using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class Calculator
    {
        public int DivideTwoNumbers(int a, int b)
        {
            try
            {
                return a / b;
            }
            catch (DivideByZeroException ex)
            {

                throw new ParameterBWasZeroException("Parameter b should not be zero because of maths", ex);
            }
        }
    }
}
