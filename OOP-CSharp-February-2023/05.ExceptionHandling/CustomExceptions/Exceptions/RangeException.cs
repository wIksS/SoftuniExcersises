using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions.Exceptions
{
    public class RangeException : Exception
    {
        public RangeException(int from, int to) : base($"Input cannot be less than {from} and more than {to}")
        {
            From = from;
            To = to;
        }

        public int From { get; set; }

        public int To { get; set; }
    }
}
