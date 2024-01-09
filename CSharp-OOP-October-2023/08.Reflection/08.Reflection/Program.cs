

using _08.Reflection;
Console.WriteLine("Which class data do you want to see?");
Type dynamicType = Type.GetType(Console.ReadLine());

PrintTypeMetaData(dynamicType);
//Type studentType = typeof(Student);

//PrintTypeMetaData(studentType);
//PrintTypeMetaData(typeof(DateTime));


void PrintTypeMetaData(Type type)
{
    Console.WriteLine($"FullName: {type.FullName}");
    Console.WriteLine($"Name: {type.Name}");
    Console.WriteLine($"Assembly: {type.Assembly}");
    Console.WriteLine($"BaseType: {type.BaseType.Name}");
    Console.WriteLine($"IsArray: {type.IsArray}");
    Console.WriteLine($"IsClass: {type.IsClass}");
    Console.WriteLine($"IsPublic: {type.IsPublic}");
    Console.WriteLine($"IsAbstract: {type.IsAbstract}");
}

