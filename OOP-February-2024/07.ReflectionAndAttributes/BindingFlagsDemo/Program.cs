

using System.Reflection;

Student goshko = new Student();

goshko.Name = "Georgi";
goshko.MyProperty = 55;
Type type = typeof(Student);

//FieldInfo[] fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Static);

FieldInfo[] fields = type.GetFields((BindingFlags)60);

foreach (var field in fields)
{
    Console.WriteLine($"{field.FieldType.Name} {field.Name}");
}

PropertyInfo[] properties = type.GetProperties((BindingFlags)60);
Console.WriteLine("\n\nProperties:");
foreach (var property in properties)
{
    Console.WriteLine($"{property.PropertyType.Name} {property.Name} - {property.GetValue(goshko)}");
    
}


class Student
{
    private string privateField;
    protected string protectedField;
    internal string itnernalField;
    public int publicField;

    private static string privateStaticField;

    public int MyProperty { get; set; }

    public string Name { get; set; }

}