using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class SoftwareEngineer : Employee
    {
        public SoftwareEngineer(int salary, int experience)
            :base(salary,experience)
        {

        }

        public Laptop Laptop { get; set; }

        public void Program()
        {
            Console.WriteLine("Doing nothing all day ;)");
        }
    }
}
