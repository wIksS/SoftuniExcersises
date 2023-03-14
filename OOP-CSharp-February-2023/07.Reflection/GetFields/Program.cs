

using System.Reflection;

Type type = typeof(Product);

//BindingFlags allFields = BindingFlags.NonPublic
//    | BindingFlags.Instance
//    | BindingFlags.Static
//    | BindingFlags.Public;

//Console.WriteLine((BindingFlags)60);

FieldInfo[] fields = type.GetFields((BindingFlags)60);
foreach (FieldInfo field in fields)
{
    Console.WriteLine(field.Name);
}

class Product
{
    private int privateField;
    protected int protectedField;
    internal int internalField;
    public int publicField;

    public static int publicStaticField;
}