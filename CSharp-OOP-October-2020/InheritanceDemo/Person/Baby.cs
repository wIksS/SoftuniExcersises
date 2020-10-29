using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Baby : Child
    {
        public override void Sleep()
        {
            Console.WriteLine("Baby sleep");
            base.Sleep();
            
        }
    }
}
