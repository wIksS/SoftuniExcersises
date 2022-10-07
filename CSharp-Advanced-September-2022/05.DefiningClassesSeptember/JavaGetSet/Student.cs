using System;
using System.Collections.Generic;
using System.Text;

namespace JavaGetSet
{
    public class Student
    {
        private string name;

        public void SetName(string value)
        {
            this.name = value;
        }

        public string GetName()
        {
            return this.name;
        }
    }
}
