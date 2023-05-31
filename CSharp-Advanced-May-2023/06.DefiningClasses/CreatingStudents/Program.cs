
List<Student> students = new List<Student>();

for (int i = 0; i < 3; i++)
{
    Student student = new Student();
    Console.WriteLine("Enter Student Name:");
    student.name = Console.ReadLine();

    Console.WriteLine("Enter Student Age:");
    student.age = int.Parse(Console.ReadLine());

    Console.WriteLine("Enter Student Score:");
    student.score = float.Parse(Console.ReadLine());

    students.Add(student);
}

for (int i = 0; i < students.Count; i++)
{
    Console.WriteLine($"{students[i].name} ({students[i].age}) - {students[i].score}");
}

class Student
{
    public string name"Pesho";
    public int age;
    public float score;
}