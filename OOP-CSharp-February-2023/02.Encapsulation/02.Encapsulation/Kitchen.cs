using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Encapsulation
{
    //Boloneze
    // Take 300 grams of spagheti
    // Boil water
    // Put spagheti in water for 10 minutes
    // Put meat in tigan
    // Put tomato sauce
    // Put spagheti and sauce in a dish

    //Carbonara
    // Take 300 grams of spagheti
    // Boil water
    // Put spagheti in water for 10 minutes
    // Put bacon in tigan
    // Put beshamel sauce
    // Put spagheti and sauce in a dish
    public class Kitchen
    {
        public Kitchen()
        {
            //products = new List<Product>();
        }

        public int SpaghetiCount { get; set; }
        public int MeatCount { get; set; }
        public int TomatoSauceCount { get; set; }
        public int BaconCount { get; set; }
        public int BeshamelCount { get; set; }

        public void TakeSpagheti(int grams)
        {
            Console.WriteLine($"Take {grams} grams of spagheti");
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PutSpaghetiInBoilWater()
        {
            Console.WriteLine("Put spagheti in water for 10 minutes");
        }

        public void PutBioMeatInTigan()
        {
            Console.WriteLine(" Put meat in tigan");
        }

        public void PutTomatoSauce()
        {
            Console.WriteLine("Put tomato sauce");
        }

        public void PutSpaghetiAndSauceInABowl()
        {
            Console.WriteLine(" Put spagheti and sauce in a dish");
        }
    }
}
