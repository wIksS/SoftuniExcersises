
Exception exception = new Exception("Tova e syobshenieto");

try
{
    throw exception;
}
catch (Exception ex)
{
    Console.WriteLine(ex.StackTrace);
}
Console.WriteLine(exception.Message);

NullReferenceException nullRefEx = new NullReferenceException();

DivideByZeroException div;