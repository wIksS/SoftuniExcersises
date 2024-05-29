
string[] days = {
 "Monday",
 "Tuesday",
 "Wednesday",
 "Thursday",
 "Friday",
 "Saturday",
 "Sunday"
};

int day = int.Parse(Console.ReadLine());

if (day < 1 || day > 7)
{
    Console.WriteLine("Invalid day!");
}
else
{
    Console.WriteLine(days[day - 1]);
}

