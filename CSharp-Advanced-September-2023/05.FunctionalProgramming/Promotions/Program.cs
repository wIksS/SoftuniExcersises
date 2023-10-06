
Console.WriteLine($"Today promotion: {GetPromotionPure(100, DateTime.Now)}");
Console.WriteLine($"Sunday promotion: {GetPromotionPure(100, new DateTime(2023,09,24))}");
Console.WriteLine($"Wednesday promotion: {GetPromotionPure(100, new DateTime(2023, 09, 27))}");


Console.WriteLine(GetPromotion(100));

decimal GetPromotion(decimal price)
{
    if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
    {
        price *= (decimal) 0.8;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
    {
        price *= (decimal)0.1;
    }
    if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
    {
        price *= 0.5m;
    }


    return price;
}

decimal GetPromotionPure(decimal price, DateTime today)
{
    if (today.DayOfWeek == DayOfWeek.Tuesday)
    {
        price *= (decimal)0.8;
    }
    if (today.DayOfWeek == DayOfWeek.Wednesday)
    {
        price *= (decimal)0.1;
    }
    if (today.DayOfWeek == DayOfWeek.Sunday)
    {
        price *= 0.5m;
    }


    return price;
}