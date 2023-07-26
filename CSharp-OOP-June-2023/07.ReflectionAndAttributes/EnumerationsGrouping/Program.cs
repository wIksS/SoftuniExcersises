// See https://aka.ms/new-console-template for more information
using System.Reflection;


BindingFlags flags = (BindingFlags)60;
BindingFlags allFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public;
Console.WriteLine(allFlags);
Console.WriteLine(flags);


//Day promotion = (Day)134;//Day.Monday | Day.Tuesday | Day.Sunday;

//Console.WriteLine(2 | 4 | 128);
//Console.WriteLine(promotion);
//Console.WriteLine(promotion.HasFlag(Day.Monday));
//Console.WriteLine(promotion.HasFlag(Day.Tuesday));
//Console.WriteLine(promotion.HasFlag(Day.Sunday));
//Console.WriteLine(promotion.HasFlag(Day.Wednesday));


Console.WriteLine(2 | 4);
Console.WriteLine(2 | 8);
Console.WriteLine(2 | 16);

enum Day
{
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64,
    Sunday = 128,
}