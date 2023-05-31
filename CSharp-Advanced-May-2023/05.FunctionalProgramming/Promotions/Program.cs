
Console.WriteLine($"Promotion for product is: ");
Console.WriteLine(GetPromotionPrice(100, DateTime.Now));

// impure function
decimal GetPromotionPrice(decimal productPrice, DateTime dateToday)
{
    if (dateToday.DayOfWeek == DayOfWeek.Thursday)
    {
        return productPrice - productPrice * 0.2m;
    }
    if (dateToday.DayOfWeek == DayOfWeek.Sunday)
    {
        return productPrice - productPrice * 0.4m;
    }

    return productPrice;
}