Console.WriteLine(GetPromotion(100, DateTime.Now));
Console.WriteLine(GetPromotion(100, DateTime.Now.AddDays(3)));


decimal GetPromotion(decimal price, DateTime date)
{
    if (date.DayOfWeek == DayOfWeek.Thursday)
    {
        return price * 0.8m;
    }
    if (date.DayOfWeek == DayOfWeek.Monday)
    {
        return price * 0.4m;
    }
    if (date.DayOfWeek == DayOfWeek.Sunday)
    {
        return price * 0.5m;
    }

    return price;
}


decimal GetPromotionWithoutDI(decimal price)
{
    if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
    {
        return price * 0.8m;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
    {
        return price * 0.4m;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
    {
        return price * 0.5m;
    }

    return price;
}