

using Newtonsoft.Json;
using System.Reflection;
using System.Text;

List<Student> students = new List<Student>()
{
    new Student("pesho", "petrov"),
    new Student("pesho2", "petrov4"),
    new Student("pesho3", "petrov5"),
};

string text = JsonConvert.SerializeObject(students, Formatting.Indented);

Console.WriteLine(text);

string firstObjectSerialized = SerializeObject(students[0]);
Console.WriteLine(firstObjectSerialized);

string SerializeObject(object obj)
{
    StringBuilder result = new StringBuilder();
    Type type = obj.GetType();

    PropertyInfo[] propertyInfos = type.GetProperties();
    result.AppendLine("{");

    foreach (PropertyInfo propertyInfo in propertyInfos)
    {
        result.AppendLine($" {propertyInfo.Name}:{propertyInfo.GetValue(obj)},");
    }

    result.AppendLine("}");

    return result.ToString();   
}

class Student
{
    public Student(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
        Score = 2;
    }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public int Score { get; set; }

}