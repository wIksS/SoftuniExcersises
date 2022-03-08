using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphsim
{
    public class RobotKitchen: ModernKitchen, IRobotCleaner
    {
        public override void CookMeat()
        {
            Console.WriteLine("Robot Kitchen: naj pravilno sgotvenoto meso");
        }

        public override void CookSalad()
        {
            Console.WriteLine("Robot Kitchen: gurme salata (nqma q) no nqma i kosmi");
        }

        public void RobotClean()
        {
            Console.WriteLine("Modern Kitchen: robotite shte ni prevzemat i izmiqt");
        }
    }
}
