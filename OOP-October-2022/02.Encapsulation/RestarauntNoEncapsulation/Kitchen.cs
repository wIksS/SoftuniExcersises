using System;
using System.Collections.Generic;
using System.Linq;

namespace RestarauntNoEncapsulation
{
    public class Kitchen
    {
        public Kitchen(List<Ingredient> ingredients)
        {
            this.Ingredients = ingredients;
        }


        public List<Ingredient> Ingredients { get; set; }

        public void MakeChickenRise(string specials)
        {
            var onion = Ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);

            var chicken = Ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 400);

            onion.WeightInGrams -= 100;
            chicken.WeightInGrams -= 400;
        }

        public void MakeRise(string specials)
        {
            try
            {


            var onion = Ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);
            var tomatoes = Ingredients.First(o => o.Name == "Tomatoe" && o.WeightInGrams > 200);
            var chicken = Ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 300);

            onion.WeightInGrams -= 100;
            tomatoes.WeightInGrams -= 200;
            chicken.WeightInGrams -= 300;
            }
            catch (Exception)
            {
                Console.WriteLine("Nqma systavki :( :( :(");
            }
        }


        public void UnknownOrder()
        {
            Console.WriteLine($"Ne znam kak se pravi");
        }

        public void Cook()
        {
            Console.WriteLine("We are cooking for 30 minutes");
        }

    }
}