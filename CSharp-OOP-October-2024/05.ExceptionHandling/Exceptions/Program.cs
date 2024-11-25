


Exception ex = new Exception("Softuni Exception!");



Console.WriteLine(ex.Message);
Console.WriteLine(ex.StackTrace);
Console.WriteLine(ex.InnerException);
Console.WriteLine(ex.Data);
Console.WriteLine(ex.Source);



//FormatException formatException = new FormatException("Input was not in correct format");

//throw formatException;