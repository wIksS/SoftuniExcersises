using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public interface IPrintable
    {
        void Print(int x, object y = null);

        int Size { get; set; }

        // indexators, events

    }
}
