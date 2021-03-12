using DependencyInversionAgain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionAgain
{
    public class ConsoleWriter : IWriter
    {
        public void Write(string message)
        {
            Console.WriteLine(message);
        }
    }
}
