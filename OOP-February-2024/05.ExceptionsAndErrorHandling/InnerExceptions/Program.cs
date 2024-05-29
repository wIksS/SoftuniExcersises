// S


using InnerExceptions;
using InnerExceptions.Exceptions;

try
{
    Database database = new Database();
    Console.WriteLine(database.GetAllProducts());
}
catch (DatabaseException ex)
{
    Console.WriteLine(ex.Library);
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException.Message);
    throw ex;
}