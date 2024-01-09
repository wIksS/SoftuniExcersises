

Queue<string> children = new Queue<string>(Console.ReadLine().Split());
int n = int.Parse(Console.ReadLine());

int tosses = 1;

while (children.Count != 1)
{
    string childWithPotato = children.Dequeue();
    if (tosses == n)
    {
        Console.WriteLine($"Removed {childWithPotato}");
        tosses = 0;
    }
    else
    {
        children.Enqueue(childWithPotato);
    }

    tosses++;
}

Console.WriteLine($"Last is {children.Dequeue()}");

