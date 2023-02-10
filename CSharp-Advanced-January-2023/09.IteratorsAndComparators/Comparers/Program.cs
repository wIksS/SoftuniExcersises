

List<Student> students = new List<Student>()
{
    new Student("Dimi", 2),
    new Student("Pepi",6),
    new Student("Gogi", 3),
    new Student("Adi", 3),

};

//students.Sort(new StudentsComparer());
StudentsComparer comparer = new StudentsComparer();

for (int i = 0; i < students.Count; i++)
{
    int minIndex = i;
    for (int j = i; j < students.Count; j++)
    {
        if (comparer.Compare(students[j] ,students[minIndex]) < 0)
        {
            minIndex = j;
        }
    }

    var temp = students[i];
    students[i] = students[minIndex];
    students[minIndex] = temp;
}

foreach (var student in students)
{
    Console.WriteLine($"{student.Name} - {student.Grade}");
}

class Student
{
    public Student(string name, int grade)
    {
        Grade = grade;
        Name = name;
    }

    public int Grade { get; set; }
    public string Name { get; set; }
}

class StudentsComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int result = x.Grade.CompareTo(y.Grade);
        if (result == 0)
            result = x.Name.CompareTo(y.Name);

        return result;
    }
}