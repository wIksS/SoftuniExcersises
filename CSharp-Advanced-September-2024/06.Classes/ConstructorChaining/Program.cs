Student student = new Student("Niki", 24);

student.Courses.Add("C# Advanced");

Console.WriteLine(student.Courses[0]);

DateTime dt = new DateTime();

class Student
{
    public Student()
    {
        Console.WriteLine("Empty constructor");
        Courses = new List<string>();
    }

    public Student(string name) : this()
    {
        // name courses
        Console.WriteLine("Name constructor");
        Name = name;
    }

    public Student(string name, int age) : this(name)
    {
        //name campus courses
        Console.WriteLine("Age constructor");
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public List<string> Courses { get; set; }
}