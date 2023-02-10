using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

using NUnit.Framework;
using ComputerArchitecture;

[TestFixture]
public class T003_ComputerProperties
{
    // MUST exist within project, otherwise a Compile Time Error will be thrown.
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    private class Property
    {
        public Property(Type type, string name, string modifier = null)
        {
            this.Type = type;
            this.Name = name;
            this.Modifier = modifier;
        }

        public Type Type { get; }

        public string Name { get; }

        public string Modifier { get; }
    }

    [Test]
    public void ValidateComputerProperties()
    {
        var type = GetType("Computer");

        var properties = new[]
        {
            new Property(typeof(string), "Model"),
            new Property(typeof(int), "Capacity"),
            new Property(typeof(List<CPU>), "Multiprocessor"),
            new Property(typeof(int), "Count")
        };

        ValidateProperties(type, properties);
    }

    private static void ValidateProperties(Type type, IEnumerable<Property> properties)
    {
        foreach (var expectedProperty in properties)
        {
            var expectedType = expectedProperty.Type;
            var propertyName = expectedProperty.Name;

            var actualProperty = type.GetProperty(propertyName);
            Assert.That(actualProperty, Is.Not.Null, $"{type}.{propertyName} does not exist!");

            var actualType = actualProperty.PropertyType;
            Assert.That(actualType, Is.EqualTo(expectedType), $"{type}.{propertyName} has the wrong type!");
        }
    }

    private static string GetAccessModifier(PropertyInfo actualProperty)
    {
        if (actualProperty.SetMethod == null)
            return null;

        if (actualProperty.SetMethod.IsPrivate)
            return "Private";

        if (actualProperty.SetMethod.IsPublic)
            return "Public";

        if (actualProperty.SetMethod.IsFamily)
            return "Family";

        return null;
    }

    private static Type GetCollectionType(Type modelType)
    {
        var collectionType = typeof(List<>).MakeGenericType(modelType);
        return collectionType;
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}