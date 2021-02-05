using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class EmptyConstructorConstraint<T> 
        where T : new()
    {
        public EmptyConstructorConstraint()
        {
            T x = new T();
        }
    }
}
