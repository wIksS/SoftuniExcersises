using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    internal class CompanyException : Exception
    {
        public CompanyException(string? message, Exception? innerException) : base(message, innerException)
        {
        }
    }
}
