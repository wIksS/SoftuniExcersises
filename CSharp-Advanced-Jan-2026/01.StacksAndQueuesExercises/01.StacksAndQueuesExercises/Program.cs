
int foodAmount = int.Parse(Console.ReadLine());

int[] ordersInput = Console.ReadLine().Split().Select(int.Parse).ToArray();

Queue<int> orders = new Queue<int>(ordersInput);

//348
//20 54 30 16 7 9
int maxOrder = orders.Max();

while (orders.Count > 0)
{
    if (orders.Peek() <= foodAmount)
    {
        int order = orders.Dequeue();
        foodAmount -= order;
    }
    else
    {
        break;
    }
}

Console.WriteLine(maxOrder);
if (orders.Count == 0)
{
    Console.WriteLine("Orders complete");
}
else
{
    Console.Write("Orders left:");
    while (orders.Count > 0)
    {
        Console.Write($" {orders.Dequeue()}");
    }
}