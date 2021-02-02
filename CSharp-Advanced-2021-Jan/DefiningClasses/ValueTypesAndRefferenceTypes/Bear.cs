using System;
using System.Collections.Generic;
using System.Text;

namespace ValueTypesAndRefferenceTypes
{
    class Bear
    {
        // data
        public string Name { get; set; }

        public int DaysSinceEaten { get; set; }

        public int Age { get; set; }

        // Behaviour

        public void Eat()
        {
            Console.WriteLine($"The bear {this.Name} just ate and is happy");
        }
    }
}
