

using System.Reflection;

RandomGenerator rg= new RandomGenerator();
Type type = typeof(RandomGenerator);

MethodInfo method = type.GetMethod("GenerateNumber");

int number = (int)method.Invoke(rg, new object[] {5,10});
Console.WriteLine(number);

MethodInfo staticMethod = type.GetMethod("GenerateNumberStatic");
staticMethod.Invoke(null, null);


class RandomGenerator
{

    public int GenerateNumber(int from, int to)
    {
        return new Random().Next(from,to);
    }

    public static int GenerateNumberStatic()
    {
        Console.WriteLine("Static called");
        return new Random().Next();
    }
}