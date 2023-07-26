

using CarExample;

Driver driver = new Driver(new Horse());

while (true)
{
    string choice = Console.ReadLine();

    if (choice == "Start")
    {
        driver.Start();
    }
    if (choice == "Break")
    {
        driver.Break();
    }
    if (choice == "Acc")
    {
        driver.Accelerate();
    }
}