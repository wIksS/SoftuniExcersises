

int days = int.Parse(Console.ReadLine());

int dailyPlunder = int.Parse(Console.ReadLine());

double expectedPlunder = double.Parse(Console.ReadLine());

double totalPlunder = 0;

for (int i = 1; i <= days; i++)
{
    totalPlunder += dailyPlunder;
    if (i % 3 == 0)
    {
        totalPlunder += dailyPlunder * 0.5;
       // Console.WriteLine("Third day");
    }
    if (i % 5 == 0)
    {
        //Console.WriteLine("Fifth day");
        totalPlunder = totalPlunder - totalPlunder * 30 / 100;
    }

   // Console.WriteLine($"Day {i} -> {totalPlunder}");
}

if (totalPlunder >=  expectedPlunder)
{
    Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
}
else
{
    // a / b*100
    // a -> totalPlunder 
    // b -> expectedPlunder

    double percentage = totalPlunder / expectedPlunder * 100;
    Console.WriteLine($"Collected only {percentage:f2}% of the plunder.");
}

string input = Console.ReadLine();

while (input != "end")
{
    input = Console.ReadLine();
}