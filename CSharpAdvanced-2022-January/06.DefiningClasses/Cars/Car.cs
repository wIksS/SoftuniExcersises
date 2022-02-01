using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    // accessibility modifiers
    public class Car
    {
        private int mileage;
        private Person person;

        public Person Person { get; set; }

        public int Mileage
        {
            get { return mileage; }
            set 
            {
                Console.WriteLine($"Setting value : {value}");
                if (value < 0)
                {
                    Console.WriteLine("Wrong value!!!");
                }
                else
                {
                    mileage = value;
                }
            }
        }
    }
}

