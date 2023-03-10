using _02.Encapsulation;

Kitchen kitchen = new Kitchen();

kitchen.BaconCount -= 100000000;

while (true)
{
    Console.WriteLine("Waiter what are the orders? Boloneze or Carbonara?");

    string type = Console.ReadLine();

    if (type == "Boloneze")
    {
        kitchen.TakeSpagheti(300);
        kitchen.SpaghetiCount -= 300;
        kitchen.BoilWater();
        kitchen.PutSpaghetiInBoilWater();
        kitchen.PutBioMeatInTigan();
        kitchen.PutTomatoSauce();
        kitchen.TomatoSauceCount -= 100;
        kitchen.PutSpaghetiAndSauceInABowl();

        Console.WriteLine("Order is done I am going to give it to the client!");
    }
    if (type == "Cabonara")
    {
        kitchen.TakeSpagheti(300);
        kitchen.SpaghetiCount -= 300;
        kitchen.BoilWater();
        kitchen.PutSpaghetiInBoilWater();
        kitchen.PutBioMeatInTigan();
        kitchen.PutTomatoSauce();
        kitchen.TomatoSauceCount -= 100;
        kitchen.PutSpaghetiAndSauceInABowl();
        Console.WriteLine("Order is done I am going to give it to the client!");
    }
}