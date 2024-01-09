
using System.Reflection;

Type type = typeof(Math);

MethodInfo[] methods = type.GetMethods()
    .OrderBy(m => m.Name).ToArray();

foreach (var method in methods)
{
    string result = "";
    ParameterInfo[] parameters = method.GetParameters();

    if (parameters.Length != 1  || !parameters[0].ParameterType.IsAssignableFrom(typeof(double)) || parameters[0].ParameterType.Name != "Double")
    {
        continue;
    }

    foreach (var parameter in parameters)
    {
        result += $"{parameter.ParameterType.Name} {parameter.Name}, ";
    }

    Console.WriteLine($"{method.ReturnType.Name} {method.Name}({result})");

    double value = 1000;
    Console.WriteLine(method.Invoke(null, new object[] { value }));

}

