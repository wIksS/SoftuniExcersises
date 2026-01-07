

string[] kids = Console.ReadLine().Split();

Queue<string> queue = new Queue<string>(kids);
int n = int.Parse(Console.ReadLine());
int tosses = 1;

while (queue.Count > 1)
{
    string kid = queue.Dequeue();
    if(tosses < n)
    {
        queue.Enqueue(kid);
    }
    else
    {
        Console.WriteLine($"Removed {kid}");
        tosses = 0;
    }

    tosses++;
}

Console.WriteLine($"Last is {queue.Dequeue()}");
