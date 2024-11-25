using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    internal class InvalidAgeException : Exception
    {
        public InvalidAgeException() : base("Age must be between 0 and 150")
        {

        }

        public InvalidAgeException(string message) : base(message)
        {

        }

        public string Name { get; set; }
    }
}
