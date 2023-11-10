using CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnerException
{
    public class Employee
    {
        private string name;

        public Employee(string name)
        {
            Name = name;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 2)
                {
                    throw new EmployeeException("Name should be longer than 1 symbol", this);
                }

                name = value;
            }
        }

    }
}
