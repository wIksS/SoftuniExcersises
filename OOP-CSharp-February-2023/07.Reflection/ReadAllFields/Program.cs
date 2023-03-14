
using System.Reflection;

PrintAllFields(new Product() { id=1,model="Best MOdel", price=555});
PrintAllFields(DateTime.Now);

void PrintAllFields(object obj)
{
    Type type = obj.GetType();
    FieldInfo[] fields = type.GetFields();

    foreach (FieldInfo field in fields)
    {
        Console.WriteLine($"Name: {field.Name}");
        Console.WriteLine($"DeclaringType: {field.DeclaringType.Name}");
        Console.WriteLine($"IsFamily: {field.IsFamily}");
        Console.WriteLine($"IsPublic: {field.IsPublic}");
        Console.WriteLine($"IsStatic: {field.IsStatic}");

        Console.WriteLine($"{field.Name} - {field.GetValue(obj)}");
    }
}

public class Product
{
    public  int id;
    public decimal price;
    public string model;
}

