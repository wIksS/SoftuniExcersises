

using Microsoft.Extensions.DependencyInjection;

ServiceCollection collection = new ServiceCollection();

collection.AddSingleton<ILogger, TextLogger>();
collection.AddSingleton<Company, Company>();
collection.AddSingleton<Employee, Employee>();


IServiceProvider provider = collection.BuildServiceProvider();

//ILogger logger = provider.GetRequiredService<ILogger>();

Company company = provider.GetRequiredService<Company>();

company.RaiseSalary();

Employee employee = provider.GetRequiredService<Employee>();

employee.TakeVacation(365);

class Company
{
    private ILogger logger;

    public Company(ILogger logger)
    {
        Console.WriteLine("Console Logger created!!!");
        this.logger = logger;
    }

    public void RaiseSalary()
    {
        logger.Log("Salary raised!");
        // raise salary
    }
}

class Employee
{
    private ILogger logger;

    public Employee(ILogger logger)
    {
        this.logger = logger;
    }
    public void TakeVacation(int days)
    {
        logger.Log($"Took {days} vacation. Was not enough :(");
    }
}

interface ILogger
{
    void Log(string message);
}

class ConsoleLogger : ILogger
{
    public ConsoleLogger()
    {
        Console.WriteLine("Console Logger created!!!");
    }
    public void Log(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"{DateTime.Now}:{message}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}

class TextLogger : ILogger
{

    public void Log(string message)
    {
        using (StreamWriter writer = new StreamWriter("../../../logs.txt", true))
        {
            writer.WriteLine($"{DateTime.Now}:{message}");
        }
    }
}

