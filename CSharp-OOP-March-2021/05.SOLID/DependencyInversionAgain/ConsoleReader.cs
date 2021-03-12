using DependencyInversionAgain.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversionAgain
{
    public class ConsoleReader : IReader
    {
        public string Read()
        {
            return Console.ReadLine();
        }
    }
}
