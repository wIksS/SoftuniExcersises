using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    internal class SoftUniException : Exception
    {
        public SoftUniException(string message) : base(message) { }

        public string Course{ get; set; }
    }
}
