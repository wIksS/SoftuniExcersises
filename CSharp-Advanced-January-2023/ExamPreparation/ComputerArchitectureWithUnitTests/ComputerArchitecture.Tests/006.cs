using System;
using System.Linq;
using System.Reflection;

using NUnit.Framework;
using ComputerArchitecture;

[TestFixture]
public class T006_ComputerInstance
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateCompiuterInstance()
    {
        var computerArguments = new object[] { "AlienWare", 4 };
        var computer = CreateObjectInstance(GetType("Computer"), computerArguments);

        var actualName = computer
        .GetType()
        .GetProperty("Model")
        .GetValue(computer);
        var expectedFullName = "AlienWare";

        var actualCapacity = computer
            .GetType()
            .GetProperty("Capacity")
            .GetValue(computer);
        var expectedCapacity = 4;

        Assert.AreEqual(expectedFullName, actualName);
        Assert.AreEqual(expectedCapacity, actualCapacity);

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