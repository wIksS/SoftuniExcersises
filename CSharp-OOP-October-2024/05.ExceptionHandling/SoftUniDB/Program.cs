using SoftUniDB;
using SoftUniDB.Exceptions;

try
{
    SoftUniDBRepository db = new SoftUniDBRepository("../../../Program.cs");
    db.Update(null);
}
catch (SoftUniDBException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.InnerException?.Message);
}

int n = 0;
Console.WriteLine(100/n);