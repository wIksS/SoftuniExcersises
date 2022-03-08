using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    public class OldKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Old Kitchen: izhvyrli vsìchko i izmii pepelta");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Old Kitchen: sloji go na ogynq i gledaj da ne se oparish");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Old Kitchen: nqma vegitarianci");
        }
    }
}
