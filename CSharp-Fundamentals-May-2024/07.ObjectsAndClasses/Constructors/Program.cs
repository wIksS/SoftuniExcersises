
Student student = new Student()
{ Name = "Goshko"};

student.Scores.Add(5);


class Student
{
    public string Name { get; set; }

    public List<int> Scores { get; set; }

    public List<string> Courses { get; set; }
    public Student()
    {
        Console.WriteLine("A new student was initialized");

        Scores = new List<int>();
        Courses = new List<string>() { "C# Fundamentals, OOP, DB, WEB", "JavaScript", "React" };
    }
}