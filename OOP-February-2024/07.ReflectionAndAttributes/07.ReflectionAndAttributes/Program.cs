

using System.Reflection;

Type[] types = Assembly.GetExecutingAssembly().GetTypes();

foreach (var type in types)
{
    Console.WriteLine(type.Name);
}