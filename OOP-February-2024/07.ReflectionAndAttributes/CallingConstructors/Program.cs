
using System.Reflection;

Type type = typeof(Student);

ConstructorInfo constructor = type.GetConstructors((BindingFlags)60)[0];

Student student = (Student)constructor.Invoke(new object[] { "goshko", 40 });

Console.WriteLine(student.Name);
class Student
{
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }
}