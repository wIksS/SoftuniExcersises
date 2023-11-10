using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.InterfacesAndAbstraction
{
    class SoftUniKitchen : IKitchen
    {
        public void PrepareMeatballsSoup()
        {
            Console.WriteLine("Preparing meatball soup!");
        }

        public void PrepareSpaghettiBoloneze()
        {
            Console.WriteLine("Preparing spaghetti boloneze!");
            BoilWater();
            CookOnion();
            CookGarlic();
            CookSpaghetti();
        }

        public void PrepareSteak()
        {
            Console.WriteLine("Preparing steak!");
        }

        public float Onions { get; set; }
        public float Garlic { get; set; }
        public float Spaghetti { get; set; }
        public int ChefCount { get; set; }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void CookOnion()
        {
            Console.WriteLine("Cooking onion");
            Onions--;
        }

        public void CookGarlic()
        {
            Console.WriteLine("Cooking Garlic");
            Garlic--;
        }

        public void CookSpaghetti()
        {
            Console.WriteLine("Cooking Spagetti");
            Spaghetti--;
        }
    }
}
