
Employee employee = null;
while (employee == null)
{
    try
    {
        employee = new Employee(Console.ReadLine());
    }
    catch (ArgumentException e)
    {
        Console.WriteLine($"Name should be more than 1 symbol Try again!");
    }

}

Console.WriteLine("Everything works!");

class Employee
{
    private string name;
    private Logger logger;

    public Employee(string name)
    {
        Name = name;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length < 2)
            {
                throw new ArgumentException("Name should be longer than 1 symbol");
            }

            logger.Log("New Employee created!");
            name = value;
        }
    }

}