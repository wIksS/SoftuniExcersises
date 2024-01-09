
using System.Reflection;

Type studentType = typeof(Student);

ConstructorInfo constructorInfo = studentType.GetConstructor(new Type[] { typeof(int), typeof(double), typeof(decimal) });

Student student = (Student) constructorInfo.Invoke(new object[] { 5, 6d, 7m });
Console.WriteLine();
ConstructorInfo[] constructors = studentType.GetConstructors();

foreach (var constructor in constructors)
{
    ParameterInfo[] parameters = constructor.GetParameters();
    Console.WriteLine(parameters.Count());
    foreach (var parameter in parameters)
    {
        Console.Write($"{parameter.ParameterType.Name} {parameter.Name}, ");
    }

    Console.WriteLine();
}



class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Score = 2;
    }

    public Student()
    {

    }

    public Student(int x, double y, decimal z)
    {
        Console.WriteLine(x);
        Console.WriteLine(y);
        Console.WriteLine(z);
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Score { get; set; }

}