SoftUni Judge
Contests 
Submissions
Feedback
Administration 
Hello, Viktor_Dakov!
Log out
Search
Details
Problem
02. Animals

Input
using System;
using System.Linq;
using System.Reflection;
using Animals;
using NUnit.Framework;

[TestFixture]
public class CatOverride
{
    private static readonly Assembly ProjectAssembly = typeof(StartUp).Assembly;

    [Test]
    public void TestMethod()
    {
        Type type = GetType("Cat");
        var catParams = new object[]
        {
            "Peter", "Whiskas"
        };

        var cat = Activator.CreateInstance(type, catParams);
        var result = cat.GetType().GetMethod("ExplainSelf").Invoke(cat, null).ToString();

        StringAssert.Contains("MEEOW", result);
    }

    private static Type GetType(string name)
    {
        var type = ProjectAssembly
            .GetTypes()
            .FirstOrDefault(t => t.Name == name);

        return type;
    }
}

