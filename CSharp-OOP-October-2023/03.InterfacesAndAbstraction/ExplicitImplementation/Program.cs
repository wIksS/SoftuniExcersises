
IDriver pilot = new Pilot();
pilot.Drive();

interface IDriver
{
    void Drive();
}

interface IPilot
{
    void Drive();
}

class Pilot : IDriver, IPilot
{
    void IPilot.Drive()
    {
        Console.WriteLine("Pilot Driving");
    }

    void IDriver.Drive()
    {
        Console.WriteLine("Driver Driving");
    }
}