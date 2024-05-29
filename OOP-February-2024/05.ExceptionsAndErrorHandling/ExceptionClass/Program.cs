

Exception ageException = new Exception("Your age cannot be less than zero :(");
ageException.Data["Test"] = 5;

Console.WriteLine($"Message: {ageException.Message}");
Console.WriteLine($"Source: {ageException.Source}");
Console.WriteLine($"Data: {ageException.Data["Test"]}");
Console.WriteLine($"TargetSite: {ageException.TargetSite}");
Console.WriteLine($"StackTrace: {ageException.StackTrace}");

throw ageException;