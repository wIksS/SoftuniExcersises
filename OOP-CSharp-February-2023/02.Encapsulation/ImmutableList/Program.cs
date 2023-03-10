
Student student = new Student();

//student.Age = 5;

Console.WriteLine(student.Age);

Console.WriteLine(student.Grades[0]);

class Student
{
    public Student()
    {
        age = 20;
        grades = new List<int>();
        grades.Add(2);
        grades.Add(6);
        grades.Add(4);
    }

    private int age;

    public int Age
    {
        get { return age; }
    }

    private List<int> grades;

    public IReadOnlyList<int> Grades
    {
        get { return grades.AsReadOnly(); }
    }
}