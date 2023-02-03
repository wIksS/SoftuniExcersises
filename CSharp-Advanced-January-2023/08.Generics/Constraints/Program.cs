using System.Text;

Console.WriteLine(GetBiggestElement(11, 22, 3));
int biggest = GetBiggestElement<int>(1, 2, 3);
StringBuilder sb = new StringBuilder();
//StringBuilder biggestSb = GetBiggestElement<StringBuilder>(sb,sb,sb); 

List<Student> students = new List<Student>() { new Student(3), new Student(2), new Student(5.50) };

Student biggestStudent = GetBiggestElement<Student>(students[0], students[1], students[2]);

Console.WriteLine(biggestStudent.AverageGrade);

T GetBiggestElement<T>(T first, T second, T third) where T : IComparable<T>
{
    if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
    {
        return first;
    }
    if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
    {
        return second;
    }
    if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
    {
        return third;
    }

    return default;
}

class Student : IComparable<Student>
{
    public Student(double averageGrade)
    {
        AverageGrade = averageGrade;
    }

    public double AverageGrade { get; set; }

    public int CompareTo(Student other)
    {
        if (this.AverageGrade < other.AverageGrade)
        {
            return -1;
        }
        else if(AverageGrade == other.AverageGrade)
        {
            return 0;
        }
        else
        {
            return 1;
        }
    }
}