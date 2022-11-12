using StudentNamespace;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModifiersAnotherAssembly
{
    internal class SoftuniStudent : Student
    {

        public SoftuniStudent()
        {
            this.protectedField = 5;
        }
    }
}
