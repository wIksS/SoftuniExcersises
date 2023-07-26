

using RestarauntExample;

Waiter waiter = new Waiter(new MolucarKitchen());

while (true)
{
    waiter.TakeOrder(Console.ReadLine());
}