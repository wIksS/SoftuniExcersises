
Student pepi = new Student("Pepi", 3);

Console.WriteLine(pepi.CompareTo(2));

Console.WriteLine(pepi.CompareTo(4));


class Student : IComparable<Student>, IComparable<int>
{
    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public string Name { get; set; }
    public int Score { get; set; }


    public int CompareTo(Student other)
    {
        // then by
        if (Score == other.Score)
        {
            return Name.CompareTo(other.Name);
        }

        return Score.CompareTo(other.Score);
    }

    public int CompareTo(int other)
    {
        return Score.CompareTo(other);
    }
}