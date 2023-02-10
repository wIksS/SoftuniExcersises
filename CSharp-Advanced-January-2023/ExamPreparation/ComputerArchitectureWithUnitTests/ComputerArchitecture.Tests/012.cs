using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using ComputerArchitecture;

[TestFixture]
public class T012_Computer_GetCpu
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ReturnCPUByBrand()
    {
        var computerArguments = new object[] { "AlienWare", 4 };
        var computer = CreateObjectInstance(GetType("Computer"), computerArguments);

        var multiprocessor = computer.GetType().GetProperty("Multiprocessor").GetValue(computer);

        double frequency = 8.7;
        var cpuArguments1 = new object[] { "AMD FX-8370", 8, frequency };
        var cpu1 = CreateObjectInstance(GetType("CPU"), cpuArguments1);
        var cpuArguments2 = new object[] { "AMD FX-83701", 8, frequency + 1 };
        var cpu2 = CreateObjectInstance(GetType("CPU"), cpuArguments2);
        var cpuArguments3 = new object[] { "AMD FX-83702", 8, frequency + 2 };
        var cpu3 = CreateObjectInstance(GetType("CPU"), cpuArguments3);
        var cpuArguments4 = new object[] { "AMD FX-83703", 8, frequency + 4 };
        var cpu4 = CreateObjectInstance(GetType("CPU"), cpuArguments4);


        InvokeMethod(computer, "Add", new object[] { cpu1 });
        InvokeMethod(computer, "Add", new object[] { cpu2 });
        InvokeMethod(computer, "Add", new object[] { cpu3 });
        InvokeMethod(computer, "Add", new object[] { cpu4 });

        var returnedCpu =
            InvokeMethod(computer, "GetCPU", new object[] { "AMD FX-83701" });

        var expectedType = returnedCpu.GetType();

        var returnedFrequncy = returnedCpu
            .GetType()
            .GetProperty("Frequency")
            .GetValue(returnedCpu);

        var validateReturnedName = returnedCpu
           .GetType()
           .GetProperty("Brand")
           .GetValue(returnedCpu);

        Assert.AreEqual(typeof(CPU), expectedType);
        Assert.AreEqual(9.7, returnedFrequncy);
        Assert.AreEqual("AMD FX-83701", validateReturnedName);
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