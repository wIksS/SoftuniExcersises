using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifiers
{
     class Base
    {
        // access modifiers
        private int privateField;
        protected int protectedField;
        internal int internalField;
        public int publicField;

        public Base()
        { }

        public virtual  void BaseMethod()
        {
            Console.WriteLine("I am the base method");
        }
    }
}
