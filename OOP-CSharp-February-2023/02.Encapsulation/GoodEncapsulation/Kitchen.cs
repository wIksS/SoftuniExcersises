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
        private int spaghetiCount;
        private int meatCount;
        private int tomatoSauceCount;
        private int baconCount;
        private int beshamelCount;

        public void CookSpaghetiCarbonara()
        {
            BoilSpagheti(300);
            PutBioBaconInTigan();
            PutBeshamelInTigan();
            PutSpaghetiAndSauceInABowl();
        }

        public void CookSpaghetiBoloneze()
        {
            BoilSpagheti(300);
            PutBioBaconInTigan();
            PutSpaghetiAndSauceInABowl();
        }

        private void BoilSpagheti(int grams)
        {
            TakeSpagheti(grams);
            BoilWater();
            PutSpaghetiInBoilWater();
        }

        private void TakeSpagheti(int grams)
        {
            Console.WriteLine($"Take {grams} grams of spagheti");
            spaghetiCount -= grams;
        }

        private void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        private void PutSpaghetiInBoilWater()
        {
            Console.WriteLine("Put spagheti in water for 10 minutes");
        }

        private void PutMeatInTigan()
        {
            Console.WriteLine(" Put meat in tigan");
            meatCount -= 200;
        }

        private void PutBioBaconInTigan()
        {
            Console.WriteLine(" Put bacon in tigan");
            baconCount -= 200;
        }
        private void PutBeshamelInTigan()
        {
            Console.WriteLine(" Put beshamel in tigan");
            beshamelCount -= 100;
        }
        private void PutTomatoSauce()
        {
            Console.WriteLine("Put tomato sauce");
            tomatoSauceCount -= 100;
        }

        private void PutSpaghetiAndSauceInABowl()
        {
            Console.WriteLine(" Put spagheti and sauce in a dish");
        }
    }
}
