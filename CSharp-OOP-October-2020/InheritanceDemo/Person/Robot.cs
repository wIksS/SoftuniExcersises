using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Robot : Person
    {
        public override void Sleep()
        {
            throw new ArgumentException("Nqma syn");
        }
    }
}
