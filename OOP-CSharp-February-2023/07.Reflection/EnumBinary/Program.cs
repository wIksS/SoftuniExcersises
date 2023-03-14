
Days promotion = Days.Thursday | Days.Saturday | Days.Sunday | Days.Monday;

if (promotion.HasFlag(Days.Thursday))
{
    Console.WriteLine("Thursday Promotion");
}
if (promotion.HasFlag(Days.Saturday))
{
    Console.WriteLine("Saturday Promotion");
}
if (promotion.HasFlag(Days.Monday))
{
    Console.WriteLine("Monday Promotion");
}

Console.WriteLine((int)promotion);
Console.WriteLine(8 | 32 | 64);

enum Days
{
    Monday = 1,
    Tuesday = 2,
    Wednesday = 4,
    Thursday = 8,
    Friday = 16,
    Saturday = 32,
    Sunday = 64,
}