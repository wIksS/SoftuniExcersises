using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        private string name;
        protected int age;
        internal int hungry;
        public int publicField;

        public void Eat()
        {
            Console.WriteLine("eating...");
        }
    }
}
