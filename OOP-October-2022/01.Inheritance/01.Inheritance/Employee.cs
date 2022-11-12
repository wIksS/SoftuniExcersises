using System;
using System.Collections.Generic;
using System.Text;

namespace _01.Inheritance
{
    public class Employee
    {
        public Employee()
        {

        }
        public Employee(string name, decimal salary, int happinnes, int likelyToLeave)
        {
            Console.WriteLine($"In employee constructor with name {name}");
            Name = name;
            Salary = salary;
            HappinnesLevel = happinnes;
            LikelyToLeave = likelyToLeave;
        }

        public decimal Salary { get; set; }

        public string Name { get; set; }

        public int HappinnesLevel { get; set; }

        public int LikelyToLeave { get; set; }


        public void GetPaid()
        {
            HappinnesLevel += 10;
            Console.WriteLine($"Yooho");
        }
    }
}
