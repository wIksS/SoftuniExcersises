using System;
using System.Collections.Generic;
using System.Text;

namespace Virtual
{
    class Mouse : Animal
    {
        public sealed override void Eat()
        {
            base.Eat();
            Console.WriteLine("Mouse eating");
            Food -= 1;
        }

        public override string ToString()
        {
            return base.ToString() + "Mishkaaaa";
        }
    }

    class BabyMouse : Mouse
    {
   
    }
}
