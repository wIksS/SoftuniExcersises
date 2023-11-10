
using InnerException;

Exception ex2 = new Exception("1 level",
    new ArgumentException("2 nd level",
        new SystemException("third level")));

Console.WriteLine(ex2.InnerException.InnerException.Message);

Company company = new Company();

try
{
    company.AddEmployee("t");
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException.Message);
}