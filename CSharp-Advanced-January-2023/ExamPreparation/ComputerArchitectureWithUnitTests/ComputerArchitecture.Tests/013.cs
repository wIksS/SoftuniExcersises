using System;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

using ComputerArchitecture;
using System.Text;

[TestFixture]
public class T013_Computer_Report
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void CorrectComputerReport()
    {
        var computerArguments = new object[] { "AlienWare", 3 };
        var computer = CreateObjectInstance(GetType("Computer"), computerArguments);

        var multiprocessor = computer.GetType().GetProperty("Multiprocessor").GetValue(computer);

        double frequency = 8.7;
        var cpuArguments1 = new object[] { "AMD FX-8370", 6, frequency };
        var cpu1 = CreateObjectInstance(GetType("CPU"), cpuArguments1);
        var cpuArguments2 = new object[] { "AMD FX-83701", 8, frequency +1};
        var cpu2 = CreateObjectInstance(GetType("CPU"), cpuArguments2);
        var cpuArguments3 = new object[] { "AMD FX-83702", 10, frequency + 2 };
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

        var actualOutput =
            InvokeMethod(computer, "Report", null);

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"CPUs in the Computer AlienWare:");
        sb.AppendLine($"AMD FX-8370 CPU:");
        sb.AppendLine($"Cores: 6");
        sb.AppendLine($"Frequency: 8.7 GHz");
        sb.AppendLine($"AMD FX-83701 CPU:");
        sb.AppendLine($"Cores: 8");
        sb.AppendLine($"Frequency: 9.7 GHz");
        sb.AppendLine($"AMD FX-83702 CPU:");
        sb.AppendLine($"Cores: 10");
        sb.AppendLine($"Frequency: 10.7 GHz");

        var expectedOutput = sb.ToString().TrimEnd();

        Assert.AreEqual(actualOutput, expectedOutput);
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