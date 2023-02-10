using System;
using System.Linq;
using System.Reflection;

using NUnit.Framework;
using ComputerArchitecture;
using System.Text;

[TestFixture]
public class T005_CPUInstance
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateCPUInstance()
    {
        double frequency = 8.7;
        var cpuArguments = new object[] { "AMD FX-8370", 8, frequency };
        var cpu = CreateObjectInstance(GetType("CPU"), cpuArguments);

        var validActualResult = cpu.ToString();

        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"AMD FX-8370 CPU:");
        sb.AppendLine($"Cores: 8");
        sb.AppendLine($"Frequency: 8.7 GHz");

        var validExpectedResult = sb.ToString().TrimEnd();
        Assert.AreEqual(validActualResult.TrimEnd(), validExpectedResult.TrimEnd());
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