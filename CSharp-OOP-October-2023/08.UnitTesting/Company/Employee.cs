using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    public class Employee
    {
        public Employee()
        {
            Id = Guid.NewGuid();
        }

        public Employee(Guid id, string name, decimal salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} is paid - {Salary}";
        }
    }
}
