
DayOfWeek day = DayOfWeek.Monday;

day = DayOfWeek.Sunday;


GetPromotion(DayOfWeek.Tuesday);

void GetPromotion(DayOfWeek day)
{
    if (day == DayOfWeek.Tuesday)
    {
        Console.WriteLine("Best promotion today!");
    }
}

enum DayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}