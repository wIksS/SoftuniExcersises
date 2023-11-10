

using CompanySingleResponsbility;

Company company = new Company();

while (true)
{
    string command = Console.ReadLine();

    if (command == "new year")
    {
        company.NewYearUpdate();
    }
    if (command == "new employee")
    {
        company.AddEmployee(new Employee() { Name = "Dimitrichko" });
    }
    if (command == "report")
    {
        company.Report();
    }
}