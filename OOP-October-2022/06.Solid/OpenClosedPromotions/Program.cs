using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace OpenClosedPromotions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var types = Assembly.GetExecutingAssembly()
  .GetTypes().Where(t => typeof(IPromotion).IsAssignableFrom(t) && t != typeof(IPromotion));

            List<IPromotion> promotions = new List<IPromotion>();
            foreach (var type in types)
            {
                promotions.Add(Activator.CreateInstance(type) as IPromotion);
            }

            Store store = new Store(promotions);
                //new List<IPromotion>()
            //{
            //    //new TuesdayPromotion(),
            //    //new FridayPromotion(),
            //    //new YearlyPromotion(),
            //});

            store.Buy(new Product());
        }
    }
}
