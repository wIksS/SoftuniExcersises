
using System.Reflection;

Type type = typeof(Human);
ConstructorInfo cons = type.GetConstructor(new Type[] { typeof(string) });
Human test = cons.Invoke(new object[] { "Test"}) as Human;

ConstructorInfo[] constructorInfos = type.GetConstructors();
Console.WriteLine($"Count: {constructorInfos.Length}");
Human human = (Human)constructorInfos[0].Invoke(new object[] { });
Human human2 = (Human)constructorInfos[1].Invoke(new object[] { "Reflection"});

foreach (ConstructorInfo constructorInfo in constructorInfos)
{
    ParameterInfo[] parameters = constructorInfo.GetParameters();
    Console.WriteLine($"Constructor: {constructorInfo.Name}");
    Console.WriteLine("Parameters count: " + parameters.Length);


    foreach (ParameterInfo parameter in parameters)
    {
        Console.WriteLine($"{parameter.ParameterType.Name} {parameter.Name}");
    }
}

class Human
{
    private string name = "The Human";
    public Human()
    {

    }
    public Human(string name)
    {
        this.name = name;
    }
    public Human(string name, int age, DateTime birth, decimal salary)
    {
        this.name = name;
    }
}