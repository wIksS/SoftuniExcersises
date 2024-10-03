
decimal price = Decimal.Parse(Console.ReadLine());

Console.WriteLine($"Discounted price is: {GetPromotionPure(price, DateTime.Now)}");
Console.WriteLine($"Discounted price 2028 is: {GetPromotionPure(100, new DateTime(2024,9,24).AddYears(4))}");

// not pure
// for a given input always return the same output
// f(x) = x^2
// x= 3 f(3) = 9

decimal GetPromotionPure(decimal price, DateTime date)
{
    if (date.DayOfWeek == DayOfWeek.Tuesday)
    {
        price *= 0.8m;
    }
    if (date.DayOfWeek == DayOfWeek.Wednesday)
    {
        price *= 0.9m;
    }
    if (date.Year == 2028)
    {
        price *= 0.3m;
    }

    return price;
}


decimal GetPromotionImpure(decimal price)
{
    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
    {
        price *= 0.8m;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
    {
        price *= 0.9m;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
    {
        price *= 0.3m;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
    {
        price *= 0.4m;
    }
    if (DateTime.Now.Year == 2028)
    {
        price *= 0.9m;
    }

    return price;
}