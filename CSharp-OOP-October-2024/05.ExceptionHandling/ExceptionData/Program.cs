DivideByZeroException

int n = 0;

try
{
    Console.WriteLine(1000 / n);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine(ex.StackTrace);
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Data);
    Console.WriteLine(ex.Source);
}
