using System;
using System.Collections.Generic;
using System.Text;

namespace P01._FileStream_Before
{
    class Movie : IProgressable
    {
        public int Length {get;set;}

        public int Sent { get; set; }
    }
}
