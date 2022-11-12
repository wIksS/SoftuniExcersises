using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class Employee
    {
        private string privateField;
        protected int protectedField;
        internal int internalField;
        public int publicField;

        public string Name { get; set; }

        public void Hello()
        {
            Console.WriteLine($"Hi from Employee ${privateField}");
            Complain();
        }

        private void Complain()
        {
            Console.WriteLine($"Tezi zashto me karat da pozdravqvam??");
        }
    }
}
