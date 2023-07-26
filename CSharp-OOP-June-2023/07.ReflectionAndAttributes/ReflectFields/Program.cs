
using System.Reflection;

Type type = typeof(Car);

//FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static|BindingFlags.NonPublic | BindingFlags.Public);
FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
Car car = new Car();
foreach (FieldInfo field in fields)
{
    Console.WriteLine("Name " + field.Name);
    Console.WriteLine("Field Type Name " + field.FieldType.Name);
    //Console.WriteLine("Static " + field.IsStatic);
    //Console.WriteLine("IsPublic " + field.IsPublic);
    //Console.WriteLine("IsFamily " + field.IsFamily);
    //Console.WriteLine("IsAssembly " + field.IsAssembly);
    //Console.WriteLine("IsPrivate " + field.IsPrivate);
    Console.WriteLine(field.GetValue(car));
    Console.WriteLine("----------------");
}

PropertyInfo[] properties = type.GetProperties((BindingFlags)60);

foreach (PropertyInfo property in properties)
{
    Console.WriteLine("Name " + property.Name);
    Console.WriteLine("Field Type Name " + property.Name);
    Console.WriteLine("Static " + property);
    Console.WriteLine(property.GetValue(car));
    Console.WriteLine("----------------");
}


class Car
{
    private static string privateStaticString = "Statictest";

    private string privateString = "test";

    internal int internalInt = 5;

    protected int protectedInt;

    public string publicModel = "Stoinoist";

    public int PublicProp { get; set; }

    private string PrivateProp { get; set; }
}