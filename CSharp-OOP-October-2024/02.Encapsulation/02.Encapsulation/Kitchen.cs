using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoraunt
{
    public class Kitchen
    {
        private int onions;
        private int meat;
        private List<Chef> chefs;

        public void OrderFood(MenuItem meal, Waiter waiter)
        {
            Console.WriteLine($"Kitchen is cooking {meal}");
            switch (meal)
            {
                case MenuItem.Boloneze:
                    CookBoloneze();
                    break;
                case MenuItem.Oriz:
                    break;
                case MenuItem.MeatBalls:
                    break;
                default:
                    break;
            }

        }

        private void CookBoloneze()
        {
            Console.WriteLine("Cooking Boloneze!!!!");
            Chef chef = FindFreeChef();
            SliceOnions(100);
            CookMeat(200);
            // 10 things more......
            CheckIngredients();
        }

        private Chef FindFreeChef()
        {
            throw new NotImplementedException();
        }

        private void CheckIngredients()
        {
            if (onions < 10000)
            {
                Order("Onions");
            }
        }

        private void Order(string v)
        {
            throw new NotImplementedException();
        }

        private void CookMeat(int amount)
        {
            throw new NotImplementedException();
        }

        private void SliceOnions(int amount)
        {
            onions -= amount;
        }
    }
}
