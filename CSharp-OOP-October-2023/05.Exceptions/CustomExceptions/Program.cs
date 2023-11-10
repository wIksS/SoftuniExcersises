

using CustomExceptions;
using InnerException;

try
{

    var emp = new Employee("");

}
catch (EmployeeException e)
{
    Console.WriteLine(e.Message);
    Console.WriteLine($"Employee is {e.Employee.Name}");
    throw;
}
