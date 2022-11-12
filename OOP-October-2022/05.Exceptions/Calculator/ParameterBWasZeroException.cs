using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator
{
    internal class ParameterBWasZeroException : Exception
    {
        public ParameterBWasZeroException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
