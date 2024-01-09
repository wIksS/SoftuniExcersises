// See https://aka.ms/new-console-template for more information
using CtriticalMethods;
using NUnit.Framework.Internal;
using System.Reflection;


Type[] types = Assembly.GetExecutingAssembly().GetTypes();

foreach (var type in types)
{
    MethodInfo[] methods = type.GetMethods();

    foreach (var method in methods)
    {
        CriticalAttribute attribute = method.GetCustomAttribute<CriticalAttribute>();
        if (attribute != null)
        {
            Console.WriteLine($"{type.Name} - {method.Name} Severity: {attribute.Severity} --- {attribute.Message}");
        }
    }
}