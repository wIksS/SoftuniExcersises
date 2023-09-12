

Queue<string> children = new Queue<string>(Console.ReadLine().Split());

int tossCount = int.Parse(Console.ReadLine());
int tosses = 0;
while (children.Count > 1)
{
    tosses++;
    string childWithPotato = children.Dequeue();

    if (tosses == tossCount)
    {
        tosses = 0;
        Console.WriteLine($"Removed {childWithPotato}");
    }
    else
    {
        children.Enqueue(childWithPotato);
    }
}

Console.WriteLine($"Last is {children.Dequeue()}");
