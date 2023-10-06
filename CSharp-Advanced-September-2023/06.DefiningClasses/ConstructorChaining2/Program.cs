
Student student = new Student("Pesho", 15);

class Student
{

    public Student()
    {
        Scores = new List<int>();
    }

    public Student(string name) : this()
    {
        Name = name;
    }

    public Student(string name, int age) : this(name)
    {
        Age = age;
    }

    public string Name { get; set; }

    public int Age { get; set; }

    public List<int> Scores{ get; set; }
}