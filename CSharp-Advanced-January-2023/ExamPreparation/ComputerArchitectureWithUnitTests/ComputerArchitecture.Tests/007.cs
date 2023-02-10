using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using ComputerArchitecture;

[TestFixture]
public class T007_Computer_CountReturnsCorrectValue
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void CountMethodReturnsCorrectValue()
    {
        var computerArguments = new object[] { "AlienWare", 4 };
        var computer = CreateObjectInstance(GetType("Computer"), computerArguments);

        double frequency = 8.7;
        var cpuArguments = new object[] { "AMD FX-8370", 8, frequency };
        var cpu = CreateObjectInstance(GetType("CPU"), cpuArguments);


        InvokeMethod(computer, "Add", new object[] { cpu });

        var actualCount = computer
            .GetType()
            .GetProperty("Count")
            .GetValue(computer);

        var expectedCount = 1;

        Assert.AreEqual(expectedCount, actualCount);
    }

    private static object InvokeMethod(object obj, string methodName, object[] parameters)
    {
        try
        {
            var result = obj.GetType()
                .GetMethod(methodName)
                .Invoke(obj, parameters);

            return result;
        }
        catch (TargetInvocationException e)
        {
            return e.InnerException.Message;
        }
    }

    private static object CreateObjectInstance(Type type, params object[] parameters)
    {
        try
        {
            return Activator.CreateInstance(type, parameters);
        }
        catch (TargetInvocationException e)
        {
            return e.InnerException.Message;
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name.Contains(name));

        return type;
    }
}