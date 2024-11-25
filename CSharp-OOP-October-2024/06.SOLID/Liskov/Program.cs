

using Liskov;

Company company = new Company();
var progammer = new Programmer();
company.Workers.Add(progammer);
company.EmployedWorkers.Add(progammer); 

company.Workers.Add(new Robot());

company.Work();
company.TakeBreak();