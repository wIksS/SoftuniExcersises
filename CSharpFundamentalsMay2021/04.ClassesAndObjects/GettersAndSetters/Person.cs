using System;
using System.Collections.Generic;
using System.Text;

namespace GettersAndSetters
{
    class Person
    {
        private string firstName;
        private string lastName;

        public string FirstName
        {
            get
            {
                if (String.IsNullOrEmpty(firstName))
                {
                    return "Person not named";
                }
                return firstName;
            }
            set
            {
                if (value == "Pesho")
                {
                    Console.WriteLine("Pisna mi ot tozi pesho");
                    return;
                }

                firstName = value;
            }
        }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        //public string GetFirstName()
        //{
        //    if (String.IsNullOrEmpty(firstName))
        //    {
        //        return "Person not named";
        //    }
        //    return firstName;
        //}

        //public void SetFirstName(string value)
        //{
        //    if (value == "")
        //    {
        //        Console.WriteLine("Zashto me lyjesh?");
        //        return;
        //    }
        //    firstName = value;
        //}
    }
}
