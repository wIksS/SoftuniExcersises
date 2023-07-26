

using System.Reflection;

string[] array = new string[] { "Class2", "Drawer", "Logger" };
Type[] types = Assembly.GetExecutingAssembly().GetTypes().Where(t=>t.IsInterface).ToArray();

Console.WriteLine($"Classes count: {types.Length -1}");

foreach (Type type in types)
{
    if (type.Name == "Program")
    {
        continue;
    }
    Console.WriteLine(type.Name);
}

