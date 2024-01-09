﻿namespace Handball.IO
{
    using Handball.IO.Contracts;
    using System;
    public class Writer : IWriter
    {
        public void Write(string message) => Console.Write(message);

        public void WriteLine(string message) => Console.WriteLine(message);
    }
}
