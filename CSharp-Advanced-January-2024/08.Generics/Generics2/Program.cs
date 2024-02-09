
var x = 5;

WriteLine<string>("text","","");
WriteLine<int>(5,5,5);
WriteLine<DateTime>(DateTime.Now, DateTime.Now, DateTime.Now);

void WriteLine<T>(T text, T text2, T text3)
{
    T x;

    x = text;


    Console.WriteLine(text);
}