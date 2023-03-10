using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Student
    {
        private int privateField;
        protected int protectedField;
        internal int internalField;
        public int publicField;

        int defaultPrivateField;

        public int InternalProp { get; set; }

        public int PublicProp { get; set; }

        internal void IntermalMethod()
        {

        }

        public void PublicMethod()
        {

        }
    }

    public class PublicStudent { }

    internal class InternalStudent { }


}
