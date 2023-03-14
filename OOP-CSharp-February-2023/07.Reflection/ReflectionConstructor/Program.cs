
using ConstructorReflection;
using System.Reflection;

Type type = typeof(Product);

ConstructorInfo[] constructors = type.GetConstructors();

foreach (ConstructorInfo constructor in constructors)
{
    ParameterInfo[] parameters = constructor.GetParameters();   

    object[] paramValues = new object[parameters.Length];

    int index = 0;
    foreach (ParameterInfo paramInfo in parameters)
    {
        paramValues[index++] = GetDefault(paramInfo.ParameterType);
    }

    //Product product = Activator.CreateInstance(type, paramValues) as Product;
    Product product = constructor.Invoke(paramValues) as Product;
    Console.WriteLine(product.Id);
    Console.WriteLine(product.Price);
    Console.WriteLine(product.Model);
}






object GetDefault(Type type)
{
    if (type.IsValueType)
    {
        return Activator.CreateInstance(type);
    }
    return null;
}