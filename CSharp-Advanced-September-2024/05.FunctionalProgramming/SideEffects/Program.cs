


decimal price = Decimal.Parse(Console.ReadLine());
DateTime date = DateTime.Now;


GetPromotionPure(price);

decimal GetPromotionPure(decimal price)
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

    date = date.AddDays(1);
    Console.WriteLine("Called promotion");

    return price;
}
