using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    public class TeamLead : Employee
    {
        public void FixBugs()
        {
            Console.WriteLine($"Fixing bugs by programmers all day :(");
        }
    }
}
