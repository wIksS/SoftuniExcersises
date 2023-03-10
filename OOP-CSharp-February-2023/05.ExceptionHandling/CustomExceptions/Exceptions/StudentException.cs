using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions.Exceptions
{
    public class StudentException : Exception
    {
        public StudentException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
