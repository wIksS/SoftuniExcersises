

using System.Reflection;

Console.WriteLine(Weekdays.Wednesday | Weekdays.Sunday);

Console.WriteLine("Here: " + (Weekdays.Wednesday | Weekdays.Sunday | Weekdays.Monday | Weekdays.Tuesday | Weekdays.Saturday));


Weekdays combined = (Weekdays)51;

Console.WriteLine(combined);

[Flags]
enum Weekdays
{
    Monday=0,
    Tuesday=1,
    Wednesday=2,
    Thursday=4,
    Friday=8,
    Saturday=16,
    Sunday=32,
}