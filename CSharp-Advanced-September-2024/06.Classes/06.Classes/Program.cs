Campus softuniCampus = new Campus()
{
    address = "Aleksander Malinov 34",
    name = "SoftUni Campus"
};


// Student - Goshko
Student studentNiki = new Student();
studentNiki.campus = softuniCampus;
studentNiki.name = Console.ReadLine();

studentNiki.age = int.Parse(Console.ReadLine());
studentNiki.scores = new List<double>();
studentNiki.averageScore = double.Parse(Console.ReadLine());

studentNiki.courses = new List<Course>();

PrintStudent(studentNiki);

void PrintStudent(Student student)
{
    Console.WriteLine(student.name);
    Console.WriteLine(student.age);
    Console.WriteLine(student.averageScore);
    Console.WriteLine(student.courses.Count);

    Console.WriteLine($"Campus: {student.campus.name} - {student.campus.address}");
}


class Student
{
    public string name;
    public int age;
    public double averageScore;
    public List<double> scores;
    public List<Course> courses;
    public Campus campus;
}

class Campus
{
    public string name;
    public string address;
}

class Course
{
    public string name;
    public string author;
}