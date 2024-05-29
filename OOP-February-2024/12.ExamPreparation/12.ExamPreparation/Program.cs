


Console.WriteLine(nameof(DateTime));
Type t = typeof(DateTime);

Method(DateTime.Now);

void Method(object obj)
{
    Type type = obj.GetType();
}