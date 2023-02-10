
SortedDictionary<Student, string> studentsCity = new SortedDictionary<Student, string>(new StudentsComparer())
{
    { new Student("Dimi", 2),"Plovdiv" },
    { new Student("Pepi",6) ,"Sofia" },
    { new Student("Gogi", 3),"Varna" },
    { new Student("Adi", 3) ,"Burgas" },
};


foreach (var student in studentsCity)
{
    Console.WriteLine($"{student.Key.Name}:{student.Key.Grade} - {student.Value}");
}

class Student : IComparable<Student>
{
    public Student(string name, int grade)
    {
        Grade = grade;
        Name = name;
    }

    public int Grade { get; set; }
    public string Name { get; set; }

    public int CompareTo(Student other)
    {
        int result = Grade.CompareTo(other.Grade);
        if (result == 0)
            result = Name.CompareTo(other.Name);

        return result;
    }
}

class StudentsComparer : IComparer<Student>
{
    public int Compare(Student x, Student y)
    {
        int result = x.Name.CompareTo(y.Name);
        if (result == 0)
            result = x.Grade.CompareTo(y.Grade);

        return result;
    }
}