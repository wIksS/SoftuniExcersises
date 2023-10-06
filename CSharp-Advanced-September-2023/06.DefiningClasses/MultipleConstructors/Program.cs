
Student s = new Student("Pesho", 15);
class Student
{
    public Student()
    {
        Console.WriteLine("Base Constructor");
    }

    public Student(string name) : this()
    {
        Name = name;
    }

    public Student(string name, int age): this("With Name")
    {
        Name = name;
        Age = age;
    }

    public Student(string name, int age, double score)
    {
        Name = name;
        Age = age;
        Score = score;
    }

    public string Name { get; set; }
    public int Age { get; set; }
    public double Score { get; set; }
}