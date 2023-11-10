using InnerException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomExceptions
{
    public class EmployeeException : Exception
    {
        public EmployeeException(string message, Employee employee) : base (message + " in employee")
        {
            Employee = employee;
        }

        public Employee Employee { get; set; }

        public override string ToString()
        {
            return Message;
        }
    }
}
