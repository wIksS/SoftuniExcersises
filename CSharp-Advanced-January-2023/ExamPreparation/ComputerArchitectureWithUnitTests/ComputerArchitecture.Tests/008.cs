using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using ComputerArchitecture;

[TestFixture]
public class T008_Computer_AddMethodNotEnoughSpace
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void AddWhenCapacityIsFull()
    {
        var computerArguments = new object[] { "AlienWare", 4 };
        var computer = CreateObjectInstance(GetType("Computer"), computerArguments);

        var multiprocessor = computer.GetType().GetProperty("Multiprocessor").GetValue(computer);

        double frequency = 8.7;
        var cpuArguments1 = new object[] { "AMD FX-8370", 8, frequency };
        var cpu1 = CreateObjectInstance(GetType("CPU"), cpuArguments1);
        var cpuArguments2 = new object[] { "AMD FX-83701", 8, frequency };
        var cpu2 = CreateObjectInstance(GetType("CPU"), cpuArguments2);
        var cpuArguments3 = new object[] { "AMD FX-83702", 8, frequency };
        var cpu3 = CreateObjectInstance(GetType("CPU"), cpuArguments3);
        var cpuArguments4 = new object[] { "AMD FX-83703", 8, frequency };
        var cpu4 = CreateObjectInstance(GetType("CPU"), cpuArguments4);
        var cpuArguments5 = new object[] { "AMD FX-83704", 8, frequency };
        var cpu5 = CreateObjectInstance(GetType("CPU"), cpuArguments5);


        InvokeMethod(computer, "Add", new object[] { cpu1 });
        InvokeMethod(computer, "Add", new object[] { cpu2 });
        InvokeMethod(computer, "Add", new object[] { cpu3 });
        InvokeMethod(computer, "Add", new object[] { cpu4 });
        InvokeMethod(computer, "Add", new object[] { cpu5 });

        var actualCount = computer
            .GetType()
            .GetProperty("Count")
            .GetValue(computer);

        var multiprocessorCount = multiprocessor
            .GetType()
            .GetProperty("Count")
            .GetValue(multiprocessor);

        var expectedCount = 4;

        Assert.AreEqual(expectedCount, actualCount);
        Assert.AreEqual(expectedCount, multiprocessorCount);
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