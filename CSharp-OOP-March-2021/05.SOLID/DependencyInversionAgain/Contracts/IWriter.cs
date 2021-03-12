using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionAgain.Contracts
{
    public interface IWriter
    {
        void Write(string message);
    }
}
