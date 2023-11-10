using _03.InterfacesAndAbstraction.Kitchens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InterfacesAndAbstraction
{
    class Waiter
    {
        private IKitchen kitchen;

        public Waiter()
        {
            kitchen = new ModernKitchen();
        }

        public void OrderFood(string food)
        {
            switch (food)
            {
                case "boloneze":
                    kitchen.PrepareSpaghettiBoloneze();
                    break;
                case "supa":
                    kitchen.PrepareMeatballsSoup();
                    break;
                case "steak":
                    kitchen.PrepareSteak();
                    break;
                default:
                    break;
            }
        }
    }
}
