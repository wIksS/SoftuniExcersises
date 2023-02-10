
Student pesho = new Student() { Grade = 2 };
Student gosho = new Student() { Grade = 5 };

List<Student> students = new List<Student>();


students.Add(gosho);
students.Add(pesho);
students.Add(new Student() { Grade = 3 });

students.Sort();

foreach (var student in students)
{
    Console.WriteLine(student.Grade);
}
class Student : IComparable<Student>
{
    public int Grade { get; set; }

    public int CompareTo(Student other)
    {
        if (Grade < other.Grade)
        {
            return -1;
        }
        else if (Grade > other.Grade)
            return 1;
        else
        {
            return 0;
        }
    }
}