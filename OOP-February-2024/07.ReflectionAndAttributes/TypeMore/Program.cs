
Type type = typeof(StreamReader);

Type baseType = type.BaseType;

PrintTypeInformation(type);
PrintTypeInformation(baseType);
PrintTypeInformation(baseType.BaseType);
PrintTypeInformation(baseType.BaseType.BaseType);

Console.WriteLine("Interfaces: ");

Type[] interfaces = typeof(DateTime).GetInterfaces();
foreach (Type interfaceType in interfaces)
{
    PrintTypeInformation(interfaceType);
}

void PrintTypeInformation(Type type)
{
    Console.WriteLine($"Name {type.Name}");
}