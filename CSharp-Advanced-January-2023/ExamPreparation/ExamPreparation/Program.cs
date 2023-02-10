Stack<int> miligrams = new Stack<int>(
    Console.ReadLine().Split(", ").Select(int.Parse));
Queue<int> drinks = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));

int totalCaffein = 0;

while (miligrams.Count > 0 && drinks.Count > 0)
{
    int lastCaffein = miligrams.Pop();
    int firstDrink = drinks.Dequeue();
    int multiplication = lastCaffein * firstDrink;

    if (totalCaffein + multiplication <= 300)
    {
        totalCaffein += multiplication;
    }
    else
    {
        drinks.Enqueue(firstDrink);
        totalCaffein -= 30;
        if (totalCaffein < 0 )
        {
            totalCaffein = 0;
        }
    }
}

if (drinks.Count > 0)
{
    Console.WriteLine($"Drinks left: {String.Join(", ", drinks)}");
}
else
{
    Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
}

Console.WriteLine($"Stamat is going to sleep with {totalCaffein} mg caffeine.");

