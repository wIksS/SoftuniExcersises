
using System.Reflection;
using TypeClass;

Product product = new Product()
{
    field1 = 5,
    field2 = 6,
    field355 = 7,
    id = 8,
    model = 9,
    price = 10
};


while (true)
{
    Console.WriteLine("Which field you want to read?");
    string fieldName = Console.ReadLine();
    try
    {
        GetPropertyValue(DateTime.Now, fieldName);
    }
    catch (Exception)
    {
        Console.WriteLine("No Such Property!");
    }
}

void GetPropertyValue(object obj, string fieldName)
{
    Type type = obj.GetType();

    PropertyInfo prop = type.GetProperty(fieldName);
    Console.WriteLine(prop.GetValue(obj));

    //field.SetValue(product, field.GetValue(product) + "Hey");
}