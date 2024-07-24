
Student pesho = new Student();

pesho.name = "Pesho studenta";
pesho.age = 19;

Student student1 = new Student();
student1.name = Console.ReadLine();

Student student2 = new Student();
student2.name = Console.ReadLine();

void PrintStudent(Student student)
{
    Console.WriteLine(student.name);
    Console.WriteLine(student.age);
}

class Student
{
    public string name;
    public int age;
    public int averageScore;
    public List<int> scores;
    public List<string> courses;
}

