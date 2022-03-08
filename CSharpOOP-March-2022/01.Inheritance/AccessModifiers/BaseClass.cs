using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
    class BaseClass
    {
        private int x =5;
        protected int q;

        internal int y;
        public int z;

        protected void BaseMethod()
        {
            Console.WriteLine(x);
        }
    }
}
