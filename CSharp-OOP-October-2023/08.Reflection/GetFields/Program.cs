

using System.Reflection;

Console.WriteLine((BindingFlags)60);
Type type = typeof(Cat);
Cat cat = new Cat();
//FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
FieldInfo[] fields = type.GetFields((BindingFlags)60);

foreach (FieldInfo field in fields)
{
    Console.WriteLine($"Name of field {field.Name}");
    Console.WriteLine($"Name of field type {field.FieldType.Name}");

    Console.WriteLine($"Static {field.IsStatic}");
    Console.WriteLine($"Private {field.IsPrivate}");
    Console.WriteLine($"Protected {field.IsFamily}");
    Console.WriteLine($"Internal {field.IsAssembly}");
    Console.WriteLine($"Public {field.IsPublic}");

    Console.WriteLine($"Field Value {field.GetValue(cat)}");
    Console.WriteLine("------------------------------------\n--------------------------");
}

PropertyInfo[] properties = type.GetProperties((BindingFlags)60);

foreach (PropertyInfo property in properties)
{
    Console.WriteLine($"Name of field {property.Name}");
    Console.WriteLine($"Name of field type {property.PropertyType.Name}");


    Console.WriteLine($"Property Value {property.GetValue(cat)}");
    Console.WriteLine("------------------------------------\n--------------------------");
}

public class Cat
{
    private int privateField;
    protected string protectedField = "treto";
    internal string itnernalField="drugo";
    public string publicField ="neshto";
    public static string staticField;


    public int Age { get; set; }
}