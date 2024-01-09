
using System.Reflection;

Cat peshoCat = new Cat();

peshoCat.publicField = "1155555";

FieldInfo field = typeof(Cat).GetField("publicField", (BindingFlags)60);

field.SetValue(peshoCat, "changed " + (string)field.GetValue(peshoCat));

string value = (string)field.GetValue(peshoCat);

Console.WriteLine(value);

public class Cat
{
    private int privateField = 5;
    protected string protectedField;
    internal string itnernalField;
    public string publicField;
    public static string staticField;
}