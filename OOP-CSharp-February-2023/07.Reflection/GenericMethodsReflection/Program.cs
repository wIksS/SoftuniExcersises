

using System.Reflection;

MethodInfo method = typeof(Generic).GetMethods()[0];

if (method.IsGenericMethod)
{
    method = method.MakeGenericMethod(typeof(DateTime));
}

Console.WriteLine(method.Invoke(new Generic(), new object[] { DateTime.Now }));

class Generic
{
    public T GenericMethod<T>(T type1)
    {
        return type1;   
    }
}