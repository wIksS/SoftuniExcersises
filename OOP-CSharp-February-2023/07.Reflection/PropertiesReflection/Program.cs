
using System.Reflection;

PropertyInfo[] properties = typeof(Product).GetProperties((BindingFlags)60);

foreach (PropertyInfo property in properties)
{

    Console.WriteLine("Name: " + property.Name);
    Console.WriteLine("Type: " + property.PropertyType.Name);
}

class Product
{
    public int Prop1 { get; set; }

    private string Prop2 { get; set; }
}