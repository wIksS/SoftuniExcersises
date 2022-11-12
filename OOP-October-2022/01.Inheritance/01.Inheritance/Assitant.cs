using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    internal class Assitant : Employee
    {
        public Assitant(string name, decimal salary, int happinnes, int likelyToLeave) : base(name,salary, happinnes, likelyToLeave)
        {
            Name = name;
            Salary = salary;
            HappinnesLevel = happinnes;
            LikelyToLeave = likelyToLeave;
        }
    }
}
