

using Attributes;
using Shapes;
using System.Reflection;


Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.GetCustomAttribute<DocumentationAttribute>(false) != null).ToArray();
foreach (var type in types)
{
    DocumentationAttribute attr = type.GetCustomAttribute<DocumentationAttribute>(false);

    Console.WriteLine($"Documentation for {type.Name} - {attr.MoreInfo}");

    MethodInfo[] methods = type.GetMethods();
    foreach (var method in methods)
    {
        DocumentationAttribute methodAttr = method.GetCustomAttribute<DocumentationAttribute>(false);
        
        if (methodAttr != null)
        {
            Console.WriteLine($"{method.ReturnType.Name} {method.Name} - {methodAttr.MoreInfo}");
        }
    }
}
