using System;
using System.Collections.Generic;
using System.Text;

namespace GenericConstraints
{
    class InnerGenericConstraint<T>
    {

        public void DoSomething<J>(J something)
            where J : T
        {
            Console.WriteLine(something);
        }

    }
}
