using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress
{
    public class Movie : Streamable
    {
        public Movie(int length, int bytesSent) : base(length, bytesSent)
        {

        }
    }
}
