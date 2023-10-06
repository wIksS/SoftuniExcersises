

new DateTime(DateTimeKind.)
Day dayToday = Day.Monday;

dayToday = Day.Sunday;


CheckPromotion(Day.Sunday);

void CheckPromotion(Day day)
{
    if (day == Day.Sunday)
    {
        Console.WriteLine("Today is a promotion");
    }
    else
    {
        Console.WriteLine("No promotion");
    }
}

enum Day
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday,
}