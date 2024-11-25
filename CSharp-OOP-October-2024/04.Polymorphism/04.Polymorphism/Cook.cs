using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Polymorphism
{
    public class Cook : Employee
    {
        public List<string> Foods { get; set; }
        public override void Work()
        {
            Console.WriteLine("Cooking all the food");
        }
    }
}
