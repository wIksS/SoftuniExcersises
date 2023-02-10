using System;
using System.Linq;
using System.Reflection;

using NUnit.Framework;
using ComputerArchitecture;

[TestFixture]
public class T001_TypesExist
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void ValidateTypesExist()
    {
        var typesToAssert = new[]
        {
            "CPU",
            "Computer"
        };

        foreach (string typeName in typesToAssert)
        {
            Assert.That(GetType(typeName), Is.Not.Null, $"{typeName} type doesn't exist!");
        }
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}