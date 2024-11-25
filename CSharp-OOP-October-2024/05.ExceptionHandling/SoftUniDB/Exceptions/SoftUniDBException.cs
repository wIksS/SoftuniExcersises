using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniDB.Exceptions
{
    internal class SoftUniDBException : Exception
    {
        public SoftUniDBException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
