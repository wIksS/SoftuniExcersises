using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class Child : BaseClass
    {
        public void Method2()
        {
            BaseMethod();
        }
    }
}
