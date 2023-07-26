
using System.Reflection;

Type type = typeof(Worker);
Worker worker = new Worker();

MethodInfo[] methodInfos = type.GetMethods((BindingFlags)60);

foreach (MethodInfo methodInfo in methodInfos)
{
    Console.WriteLine("Name:" + methodInfo.Name);
    Console.WriteLine("Return type:" + methodInfo.ReturnType.Name);
    Console.WriteLine("Static: " + methodInfo.IsStatic);
    ParameterInfo[] parameters = methodInfo.GetParameters();
    Console.WriteLine("Parameters");
    foreach (ParameterInfo parameter in parameters)
    {
        Console.Write($"{parameter.ParameterType.Name} {parameter.Name}, ");
    }

    if (parameters.Length == 0)
    {
        Console.WriteLine(methodInfo.Invoke(worker, null));
    }

    Console.WriteLine("\n");
}

worker.Eat("");

class Worker
{

    private string PretendToWork()
    {
        return "Working, working";
    }

    [Obsolete]
    public void Eat(string meal, int volume, string test)
    {
        Console.WriteLine("Eating " + meal);
    }

    [Obsolete]
    public void Eat(string meal)
    {
        Console.WriteLine("Eating " + meal);
    }
    public void Sleep()
    {
        Console.WriteLine("Sleeping");
    }
}