using _03.InterfacesAndAbstraction;


Waiter waiter = new Waiter();

while (true)
{
    Console.WriteLine("What would you like to order?");

    string order = Console.ReadLine();

    waiter.OrderFood(order);
}





