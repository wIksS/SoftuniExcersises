
using System.Reflection;

PromotionDays promotion = PromotionDays.Monday | PromotionDays.Tuesday | PromotionDays.Sunday;

Console.WriteLine(promotion);

return;
Console.WriteLine((int)(PromotionDays.Monday | PromotionDays.Friday));

Console.WriteLine(2 | 32);

Console.WriteLine(((PromotionDays)34).HasFlag(PromotionDays.Monday));
Console.WriteLine(((PromotionDays)34).HasFlag(PromotionDays.Wednesday));
Console.WriteLine(((PromotionDays)34).HasFlag(PromotionDays.Friday));

[Flags]
enum PromotionDays
{
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64,
    Sunday = 128
}




