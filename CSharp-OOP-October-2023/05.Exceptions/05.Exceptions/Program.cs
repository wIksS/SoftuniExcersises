
int x = 0;
Console.WriteLine(5/x);

IndexOutOfRangeException outOfRange;
ArgumentException argumentEx = new ArgumentException();

NullReferenceException nullRef;

DivideByZeroException divideByZero;

Exception ex = new Exception("Ogromna greshka. Vsichko se schupi :(");

//Console.WriteLine(ex.Message);

throw ex;