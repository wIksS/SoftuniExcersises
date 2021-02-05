using System;

namespace DefiningClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Bear gogi = new Bear();
            gogi.Age = 28;
            gogi.DaysSinceEaten = 5;
            gogi.Name = "Gogi";
            gogi.Eat();

            Bear dimitrichkoBear = new Bear();
            dimitrichkoBear.Age = 28;
            dimitrichkoBear.DaysSinceEaten = 2;
            dimitrichkoBear.Name = "Dimitrichko";

            Bear pouhBear = new Bear();
            pouhBear.Age = 25;
            pouhBear.DaysSinceEaten = 3;
            pouhBear.Name = "Mecho Puh";

            Bear[] bearZoo = new Bear[3] { gogi, dimitrichkoBear, pouhBear};

            foreach (Bear bear in bearZoo)
            {
                if (bear.DaysSinceEaten >= 3)
                {
                    bear.Eat();
                }
            }









            Shirt calvinKlain = new Shirt();
            calvinKlain.Size = "XXXXL";
            calvinKlain.Quantity = 55;
            calvinKlain.Price = 3;

            calvinKlain.Wash();

            Console.WriteLine($"Teniska calvin: Size -> {calvinKlain.Size} Quantity -> {calvinKlain.Quantity} Price -> {calvinKlain.Price}");
        }
    }
}
