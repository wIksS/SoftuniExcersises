

Queue<string> circle = new Queue<string>(Console.ReadLine().Split());

int n = int.Parse(Console.ReadLine());
int tosses = 1;

while (circle.Count > 1)
{
    string child = circle.Dequeue();

    if (tosses == n)
    {
        Console.WriteLine($"Removed {child}");
        tosses = 0;
    }
    else
    {
        circle.Enqueue(child);
    }

    tosses++;
}

Console.WriteLine($"Last is {circle.Dequeue()}");
