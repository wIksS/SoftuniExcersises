using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01.Stream_Progress
{
    public abstract class Streamable
    {
        public Streamable(int length, int bytesSent)
        {
            this.Length = length;
            this.BytesSent = bytesSent;
        }

        public int Length { get; set; }

        public int BytesSent { get; set; }
    }
}
