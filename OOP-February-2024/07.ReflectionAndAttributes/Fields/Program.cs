
using System.Reflection;

Type type = typeof(Student);

FieldInfo field = type.GetField("age");

Console.WriteLine(field.Name);
Console.WriteLine(field.IsPublic);
Console.WriteLine(field.IsPrivate);

Student gosho = new Student();
gosho.age = 10;

Student goshko = new Student();
goshko.age = 50;

field.SetValue(gosho, 35);

Console.WriteLine(field.GetValue(gosho));
Console.WriteLine(field.GetValue(goshko));

class Student
{
    public int age;
}