

using System.Reflection;

Type[] types= Assembly.GetExecutingAssembly()
    .GetTypes();

foreach (Type type in types)
{
    PrintTypeMetaData(type);
}

void PrintTypeMetaData(Type type)
{
    Console.WriteLine($"FullName: {type.FullName}");
    Console.WriteLine($"Name: {type.Name}");
    Console.WriteLine($"Assembly: {type.Assembly}");
    Console.WriteLine($"BaseType: {type.BaseType?.Name}");
    Console.WriteLine($"IsArray: {type.IsArray}");
    Console.WriteLine($"IsClass: {type.IsClass}");
    Console.WriteLine($"IsPublic: {type.IsPublic}");
    Console.WriteLine($"IsAbstract: {type.IsAbstract}");

    Type[] interfaces = type.GetInterfaces();

    foreach (var interfaceType in interfaces)
    {
        PrintTypeMetaData(interfaceType);
    }
}