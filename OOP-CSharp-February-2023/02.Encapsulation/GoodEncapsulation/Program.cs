using _02.Encapsulation;

Kitchen kitchen = new Kitchen();



while (true)
{
    Console.WriteLine("Waiter what are the orders? Boloneze or Carbonara?");

    string type = Console.ReadLine();

    if (type == "Boloneze")
    {
        kitchen.CookSpaghetiBoloneze();

        Console.WriteLine("Order is done I am going to give it to the client!");
    }
    if (type == "Cabonara")
    {
        kitchen.CookSpaghetiCarbonara();
        Console.WriteLine("Order is done I am going to give it to the client!");
    }
}