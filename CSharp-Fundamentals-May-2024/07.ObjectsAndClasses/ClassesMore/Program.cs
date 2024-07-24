
int n = int.Parse(Console.ReadLine());
List<Student> students = new List<Student>();

for (int i = 0; i < n; i++)
{
    Student student = ReadStudent();
    PrintStudent(student);
}

void PrintStudent(Student student)
{
    Console.WriteLine($"{student.name} - {student.age} -> {student.score}");
}

Student ReadStudent()
{
    Student student = new Student();
    Console.WriteLine("What is your name?");
    student.name = Console.ReadLine();

    Console.WriteLine("What is your age?");
    student.age = int.Parse(Console.ReadLine());

    Console.WriteLine("What is your score?");
    student.score = int.Parse(Console.ReadLine());

    return student;
}

class Student
{
    public string name;
    public int age;
    public double score;
}