using System;

namespace DependencyInversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Promotion promotion = new Promotion();

            Console.WriteLine(promotion.GetPromotion(DateTime.Now));

            Console.WriteLine(promotion.GetPromotion(DateTime.Now.AddDays(1)));
        }
    }
}
