
Queue<int> times =
    new Queue<int>(Console.ReadLine().Split().Select(int.Parse));

Stack<int> tasks =
    new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

int darthVaderDuckyCount = 0;
int thorDuckyCount = 0;
int bigBlueDuckyCount = 0;
int smallYellowDuckyCount = 0;

while (times.Count > 0)
{
    int time = times.Dequeue();
    int task = tasks.Pop();

    int taskTime = time * task;

    if (taskTime <= 60)
    {
        darthVaderDuckyCount++;
    }
    else if (taskTime <= 120)
    {
        thorDuckyCount++;
    }
    else if (taskTime <= 180)
    {
        bigBlueDuckyCount++;
    }
    else if (taskTime <= 240)
    {
        smallYellowDuckyCount++;
    }
    else
    {
        times.Enqueue(time);
        tasks.Push(task - 2);
    }
}

Console.WriteLine($"Congratulations, all tasks have been completed! Rubber ducks rewarded:");
Console.WriteLine($"Darth Vader Ducky: {darthVaderDuckyCount}");
Console.WriteLine($"Thor Ducky: {thorDuckyCount}");
Console.WriteLine($"Big Blue Rubber Ducky: {bigBlueDuckyCount}");
Console.WriteLine($"Small Yellow Rubber Ducky: {smallYellowDuckyCount}");

