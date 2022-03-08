using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    public class ModernKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Modern Kitchen: izmii spokoino");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Modern Kitchen: sgotvi mesoto");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Modern Kitchen: eto salata");
        }

        public override void CookSalad()
        {
            Console.WriteLine("Modern Kitchen: gurme salata (nqma q)");
        }
    }
}
