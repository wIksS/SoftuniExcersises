using System;
using System.Collections.Generic;
using System.Text;

namespace HidingMethods
{
    class Student : Person
    {
        public void Work()
        {
            base.Work();
            
            Console.WriteLine("Studenta ne raboti!");
        }
    }
}
