
//DateTime date = new DateTime()

Student emptyStudent = new Student();

Student student = new Student("Goshko", new List<int>(), new List<string>());
Console.WriteLine(student.Name);

class Student
{
    public Student(string name, List<int> scores, List<string> courses)
    {
        Console.WriteLine("In full constr");

        Name = name;
        Scores = scores;
        Courses = Courses;
    }
    public Student(string name)
    {
        Name = name;
    }

    public Student()
    {
        Console.WriteLine("In empty constr");
    }

    public string Name { get; set; }

    public List<int> Scores { get; set; }

    public List<string> Courses { get; set; }
}