using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceLecture.Conctract
{
    interface IRenderer
    {
        void Clear();
        void WriteLine(string message);

        void Write(string message);

        void WriteAtPosition(string message, Position position);
    }
}
