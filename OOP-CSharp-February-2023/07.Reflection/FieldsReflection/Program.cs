


using System.Reflection;
using TypeClass;


Type type = typeof(Product);

FieldInfo field = type.GetField("id");

Console.WriteLine($"Name: {field.Name}");
Console.WriteLine($"DeclaringType: {field.DeclaringType.Name}");
Console.WriteLine($"IsFamily: {field.IsFamily}");
Console.WriteLine($"IsPublic: {field.IsPublic}");
Console.WriteLine($"IsStatic: {field.IsStatic}");


