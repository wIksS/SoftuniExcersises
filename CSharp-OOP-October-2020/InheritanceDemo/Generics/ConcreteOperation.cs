using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ConcreteOperation<T> : Operation
    {
        public T Name { get; set; }


    }
}
