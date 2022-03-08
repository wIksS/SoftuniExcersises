using AbstractionAndInterfaces.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionAndInterfaces
{
    public class CareTaker 
    {
        public void Feed(IFeedable feedable)
        { 
            Console.WriteLine($"Get {feedable.Doze} {feedable.FoodType}  from inventory");
            Console.WriteLine("Feeding animal");
            feedable.Eat();
        }
    }
}
