using RestarauntEncapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Restaraunt
{
    public class Kitchen
    {
        private List<Ingredient> ingredients;

        public Kitchen(List<Ingredient> ingredients)
        {
            this.ingredients = ingredients;
        }

        public void TakeOrder(Waiter waiter, string order, string specials)
        {
            switch (order)
            {
                case "Rice": MakeRise(specials);
                    break;

                case "ChickenRise":
                    MakeChickenRise(specials);
                    break;
                default:
                    UnknownOrder();
                    waiter.ApologiseToClient("Waiter did not know that we don't this on the menu");
                    return;
            }

            waiter.OrderReady(order);
        }

        private void UnknownOrder()
        {
            Console.WriteLine("Svyrshilo e :(");
        }

        private void MakeChickenRise(string specials)
        {
            var onion = ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);

            var chicken = ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 400);

            onion.WeightInGrams -= 100;
            chicken.WeightInGrams -= 400;

            Cook();

            Console.WriteLine("ChickenRise done!");
        }

        private void MakeRise(string specials)
        {
            var onion = ingredients.First(o => o.Name == "Onion" && o.WeightInGrams > 100);
            var tomatoes = ingredients.First(o => o.Name == "Tomatoe" && o.WeightInGrams > 200);
            var chicken = ingredients.First(o => o.Name == "Chicken" && o.WeightInGrams > 300);



            onion.WeightInGrams -= 100;
            tomatoes.WeightInGrams -= 200;
            chicken.WeightInGrams -= 300;

            Cook();

            Console.WriteLine("Risotto done!");
        }

        private void Cook()
        {
            Console.WriteLine("We are cooking for 30 minutes");
        }
    }
}
