
using System.Reflection;

Type type = typeof(Student);

ConstructorInfo[] constructors = type.GetConstructors((BindingFlags)60);

foreach (ConstructorInfo constructor in constructors)
{
    ParameterInfo[] parameters = constructor.GetParameters();
    if (parameters.Length != 2)
    {
        continue;
    }
    Console.WriteLine(parameters.Length);
    foreach (ParameterInfo parameter in parameters)
    {
      
        Console.Write($"{parameter.ParameterType.Name} {parameter.Name}, ");

        if (parameter.ParameterType is int)
        {

        }
    }

    Console.WriteLine();
}

class Student
{
    public Student()
    {

    }

    public Student(string name)
    {
        Name = name;
    }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}