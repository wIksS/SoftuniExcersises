

using _07.Reflection;
using System.Reflection;


PrintProperties(typeof(Laptop), new Laptop() { Id=1,Price=100, Cores=8,GPUModel= "Skyp"});

PrintProperties(typeof(Mouse), new Mouse() { Id = 1, Price = 100, Precision = 8, Model = "Skyp" });

PrintProperties(typeof(DateTime), DateTime.Now);
PrintProperties(typeof(Random), new Random());

void PrintProperties(Type type, object obj)
{
    Console.WriteLine("\n---------------");
    Console.WriteLine(type.Name);
    Console.WriteLine("---------------");

    PropertyInfo[] properties = type.GetProperties();

    foreach (PropertyInfo property in properties)
    {
        Console.WriteLine($"{property.Name} - {property.GetValue(obj)}");
    }
}
