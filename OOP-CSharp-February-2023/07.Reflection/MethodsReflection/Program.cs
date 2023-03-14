

using System.Reflection;

Type type = typeof(Printer);

MethodInfo methods = type.GetMethod("DatePrint");
Printer printer = new Printer();

DateTime date = (DateTime)methods.Invoke(null, null);

Console.WriteLine(date);
//foreach (MethodInfo method in methods)
//{
//    Console.WriteLine(method.Name);
//    Console.WriteLine($"Return type: {method.ReturnType.Name}");
//    ParameterInfo[] parameters = method.GetParameters();

//    foreach (ParameterInfo param in parameters)
//    {
//        Console.WriteLine(param.Name);
//    }
//}

class Printer
{
    public void Print(int param1, string param2)
    {
        Console.WriteLine("Public void print");
    }

    public void PrivatePrint()
    {
        Console.WriteLine("Private void Print");
    }

    public static DateTime DatePrint()
    {
        Console.WriteLine("Date Print");

        return DateTime.Now;
    }
}