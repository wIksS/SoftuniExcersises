

using System.Reflection;

Type[] types= Assembly.GetExecutingAssembly()
    .GetTypes();

foreach (Type type in types)
{
    Console.WriteLine(type.Name);
    foreach (var method in type.GetMethods())
    {
        ObsoleteAttribute obsolete = method.GetCustomAttribute(typeof(ObsoleteAttribute)) as ObsoleteAttribute;

        if (obsolete != null)
        {
            Console.WriteLine(method.Name + " is obsolete");
        }
    }
}

