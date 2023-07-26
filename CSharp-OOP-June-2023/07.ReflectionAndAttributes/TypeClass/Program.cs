

using Writers;
using System;

PrintObjectInformation(5); 

StreamWriter date = new StreamWriter("../../../test.txt");

Type dateType = date.GetType();
PrintTypeInformation(dateType);

Console.WriteLine("Which type do you want to inspect?");
Type type = Type.GetType(Console.ReadLine());

PrintTypeInformation(type);
//PrintTypeInformation(typeof(IEnumerable<int>));

void PrintTypeInformation(Type type)
{
    Console.WriteLine("--------------");
    Console.WriteLine("FullName " + type.FullName);
    Console.WriteLine("Name " + type.Name);
    Console.WriteLine("IsAbstract " + type.IsAbstract);
    Console.WriteLine("IsArray " + type.IsArray);
    Console.WriteLine("Base type " + type.BaseType);
    Console.WriteLine("IsEnum " + type.IsEnum);
    Console.WriteLine("--------------");
}

void PrintObjectInformation(object obj)
{
    PrintTypeInformation(obj.GetType());
}



namespace Writers
{
    class BaseWriter
    {

    }
    abstract class Writer : BaseWriter
    {

    }
}