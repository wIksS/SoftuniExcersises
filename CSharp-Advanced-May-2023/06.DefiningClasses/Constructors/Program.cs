
Student student = new Student("Pesho", "Petrov", 18);
Student student2 = new Student();
Console.WriteLine(student.FirstName + " " + student.LastName);
class Student
{
    public Student()
    {
        Console.WriteLine("In the empty constructor");
        Scores = new List<float>();
    }

    public Student(string firstName, string lastName, int age) : this()
    {
        Console.WriteLine("In Student constructor");
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    public List<float> Scores{ get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
}