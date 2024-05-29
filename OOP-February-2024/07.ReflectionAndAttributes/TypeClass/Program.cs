

// abstraction for common metadata for every class
//Type type = typeof(DateTime);
//Type type = Type.GetType(Console.ReadLine());

PrintTypeInformation(new DateTime());


void PrintTypeInformation(object obj)
{
    Type type = obj.GetType();

    Console.WriteLine($"Name {type.Name}");
    Console.WriteLine($"FullName {type.FullName}");
    Console.WriteLine($"Assembly {type.Assembly}");
    Console.WriteLine($"IsArray {type.IsArray}");
    Console.WriteLine($"IsPublic {type.IsPublic}");
    Console.WriteLine($"IsGenericType {type.IsGenericType}");
    Console.WriteLine($"IsAbstract {type.IsAbstract}");
    Console.WriteLine($"IsClass {type.IsClass}");
    Console.WriteLine($"IsSealed {type.IsSealed}");
}

class CustomClass<T>
{

}