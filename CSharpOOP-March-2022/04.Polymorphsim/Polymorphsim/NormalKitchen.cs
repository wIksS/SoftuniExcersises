using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    public class NormalKitchen : Kitchen
    {
        public override void CleanKitchen()
        {
            Console.WriteLine("Normal Kitchen: izmii spokoino");
        }

        public override void CookMeat()
        {
            Console.WriteLine("Normal Kitchen: sgotvi mesoto");
        }

        public override void CookVegetarian()
        {
            Console.WriteLine("Normal Kitchen: eto salata");
        }
    }
}
