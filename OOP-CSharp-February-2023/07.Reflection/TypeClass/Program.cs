

using _07.Reflection;
using ReflectionNamespace;
using TypeClass;

//Type type = typeof(Reflected[]);
PrintTypeInfo(new Mouse());
PrintTypeInfo(new Laptop());
PrintTypeInfo(new StreamWriter("../../../Test"));
//Type type = Type.GetType(Console.ReadLine());

//PrintTypeInfo(type);

void PrintTypeInfo(object obj)
{
    Type type = obj.GetType();
    Console.WriteLine($"{type.FullName}");
    Console.WriteLine($"{type.Name}");
    Console.WriteLine($"{type.Assembly}");
    Console.WriteLine($"IsArray:{type.IsArray}");
    Console.WriteLine($"IsAbstract:{type.IsAbstract}");
    Console.WriteLine($"IsClass:{type.IsClass}");
    Console.WriteLine($"IsPublic:{type.IsPublic}");
    Console.WriteLine($"Base type:{type.BaseType.FullName}");
}

namespace ReflectionNamespace
{
    public class  Reflected
    {

    }
}

