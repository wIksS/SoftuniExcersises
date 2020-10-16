using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace GenericConstraints
{
    public class HttpRequest<T> where T: StreamReader
    {
        public void Send<O>(T data, O operation)
            where O: class
        {
           
            Console.WriteLine("Sending all the data to the WWW" + data);
        }
    }
}
