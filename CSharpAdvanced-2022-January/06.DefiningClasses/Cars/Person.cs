using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Person
    {
        public static int averageLifeSpan = 100;

        private string firstName;
        private string lastName;

        public Person()
        {
            Person.averageLifeSpan = 55;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string value)
        {
            this.firstName = value;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            { 
                this.firstName = value; 
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }

        public string FullName
        {
            get
            {
                return $"{firstName} {lastName}";
            }
        }
    }
}
