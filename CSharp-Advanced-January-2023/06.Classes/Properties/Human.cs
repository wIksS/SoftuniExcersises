using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    public class Human
    {
        private string firstName;

        private string lastName;

        public string FirstName
        {
            get { return firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get { return $"{firstName} {lastName}"; }
        }

    }
}
