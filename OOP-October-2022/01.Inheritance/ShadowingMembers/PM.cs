using System;
using System.Collections.Generic;
using System.Text;

namespace ShadowingMembers
{
    public class PM : Employee
    {
        public void Hey()
        {
            Hello();
            Console.WriteLine($"{Name}");
            Console.WriteLine(protectedField);
            Console.WriteLine(publicField);
        }
    }
}
