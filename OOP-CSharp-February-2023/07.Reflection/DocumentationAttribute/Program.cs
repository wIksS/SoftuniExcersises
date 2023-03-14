

using DocumentationAttributes;
using System.Reflection;

Type[] types = Assembly.GetExecutingAssembly()
    .GetTypes();

foreach (Type type in types)
{
    //Console.WriteLine(type.Name);
    DocumentationAttribute documentationAttr = type.GetCustomAttribute(typeof(DocumentationAttribute)) as DocumentationAttribute;

    if (documentationAttr != null)
    {
        Console.WriteLine(documentationAttr.Documentation);
    }

    foreach (var method in type.GetMethods())
    {
        documentationAttr = method.GetCustomAttribute(typeof(DocumentationAttribute)) as DocumentationAttribute;

        if (documentationAttr != null)
        {
            Console.WriteLine(documentationAttr.Documentation);
        }
    }
}
