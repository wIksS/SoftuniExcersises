
using PureFunctions;
static int Square(int x)
{
    return x * x;
}

// dirty function
static string GetDayOfWeekToday()
{
    return DateTime.Now.DayOfWeek.ToString(); 
}

// pure function
static string GetDayOfWeek(DateTime date)
{
    return date.DayOfWeek.ToString();
}

Console.WriteLine(Square(4));
Console.WriteLine($"Today is: {GetDayOfWeekToday()}");
var date = new DateTime(1993, 2, 15);
Console.WriteLine($"On {date} day of week was: {GetDayOfWeek(date)}");


int promotionPercentage = Store.GetPromotion();
