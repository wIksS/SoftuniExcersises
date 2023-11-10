using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InterfacesAndAbstraction.Kitchens
{
    public class ModernKitchen : IKitchen
    {
        public void PrepareMeatballsSoup()
        {
            Console.WriteLine("");
        }

        public void PrepareSpaghettiBoloneze()
        {
            Console.WriteLine("Modern preparing of Spaghetti Boloneze");
            HeatWaterTo133Degrees();
        }

        public void PrepareSteak()
        {
            throw new NotImplementedException();
        }

        public void HeatWaterTo133Degrees()
        {
            Console.WriteLine("Modern Heating system");
        }
    }
}
