using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptions
{
    class SoftuniException : Exception
    {

        public string CourseName { get; set; }
    }
}
